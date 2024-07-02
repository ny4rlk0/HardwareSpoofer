#include <Library/UefiBootServicesTableLib.h>
#include <Library/UefiLib.h>
#include <Include/Uefi.h>
#include <Library/UefiBootServicesTableLib.h>
#include <Library/BaseMemoryLib.h>
#include <Library/RegisterFilterLib.h>
#include <Protocol/PciIo.h>
#include <Protocol/Rng.h>
#include <Protocol/DevicePath.h>
#include <IndustryStandard/Pci.h>
#include <IndustryStandard/PciCodeId.h>

//#include "./edk/MdePkg/Include/Uefi.h"
//#include "./edk/MdePkg/Include/Library/UefiBootServicesTableLib.h"
//#include "./edk/MdePkg/Include/Protocol/PciIo.h"
//#include "./edk/MdePkg/Include/Protocol/Rng.h"
//#include "./edk/MdePkg/Include/Protocol/DevicePath.h"
//#include "./edk/MdePkg/Include/IndustryStandard/Pci.h"
//#include "edk/MdePkg/Include/Library/UefiLib.h"
//#include "./edk/MdePkg/Include/Library/BaseMemoryLib.h"
//#include "./edk/MdePkg/Include/Library/RegisterFilterLib.h"
//#include <libsmbios.h>
// UEFI Spec 2.10 section 2.4
#define IN
#define OUT
#define OPTIONAL
#define CONST const
//#include "efi.h"
// Nyarlko's HWID Spoofer Uefi 11/02/2024 13:55
// Github.com/ny4rlk0
#define MAX_DEVICES 100
//#define PCI_VENDOR_ID_OFFSET 0
//typedef uint8_t  BOOLEAN;  // 0 = False, 1 = True
//typedef int64_t  INTN;
//typedef uint64_t UINTN;
//typedef int8_t   INT8;
//typedef uint8_t  UINT8;
//typedef int16_t  INT16;
//typedef uint16_t UINT16;
//typedef int32_t  INT32;
//typedef uint32_t UINT32;
//typedef int64_t INT64;
//typedef uint64_t UINT64;
//typedef char     CHAR8;
#if defined(_M_X64) || defined(__x86_64__)
static CHAR16* ArchName = L"x86 64-bit";
#elif defined(_M_IX86) || defined(__i386__)
static CHAR16* ArchName = L"x86 32-bit";
#elif defined (_M_ARM64) || defined(__aarch64__)
static CHAR16* ArchName = L"ARM 64-bit";
#elif defined (_M_ARM) || defined(__arm__)
static CHAR16* ArchName = L"ARM 32-bit";
#elif defined (_M_RISCV64) || (defined(__riscv) && (__riscv_xlen == 64))
static CHAR16* ArchName = L"RISC-V 64-bit";
#else
#  error Unsupported architecture
#endif
//#include EFI_PROTOCOL_DEFINITION (PciIo)
EFI_GUID gEfiPciIoProtocolGuid = EFI_PCI_IO_PROTOCOL_GUID;
EFI_GUID gEfiRngProtocolGuid = EFI_RNG_PROTOCOL_GUID;
//EFI_GUID gEfiComponentName2ProtocolGuid = { 0x6A7A5CFF, 0xE8D9, 0x4F70, { 0xBA, 0xDA, 0x75, 0xAB, 0x30, 0x25, 0xCE, 0x14 } };
//#define EFI_PCI_IO_PROTOCOL_GUID \
//{ \
//0x4cf5b200, 0x68b8, 0x4ca5, { 0x9e, 0xec, 0xb2, 0x3e, 0x3f, 0x50, 0x2, 0x9a } \
//}
//#define EFI_RNG_PROTOCOL_GUID	EFI_GUID(0x3152bca5, 0xeade, 0x433d,  0x86, 0x2e, 0xc0, 0x1c, 0xdc, 0x29, 0x1f, 0x44);
EFI_DEVICE_PATH_PROTOCOL*
NextDevicePathNode(
  IN CONST EFI_DEVICE_PATH_PROTOCOL* DevicePath
);

extern EFI_BOOT_SERVICES* gBS;
// Tri-state status for Secure Boot: -1 = Setup, 0 = Disabled, 1 = Enabled
INTN SecureBootStatus = 1;

EFI_STATUS UefiMain(EFI_HANDLE ImageHandle, EFI_SYSTEM_TABLE* SystemTable) {
  //InitializeLib(ImageHandle, SystemTable);
  EFI_STATUS Status;
  EFI_HANDLE *Handles;
  UINTN HandleCount;
  //UINTN Delay = 60000000;//60 sn //3600 000000//120000000; // 120 seconds
  UINTN Delayver = 10000000;
  Print(L"Nyarlko's Hardware Spoofer is taking over UEFI... (Version: 18/02/2024 17:37)\n");
  Status = gBS->Stall(Delayver);
  //UINTN Event;
#if defined(_GNU_EFI)
  InitializeLib(ImageHandle, SystemTable);
#endif
  // Locate handles for PCI devices
  Status = gBS->LocateHandleBuffer(
    ByProtocol,
    &gEfiPciIoProtocolGuid,
    NULL,
    &HandleCount,
    &Handles
  );
  if (!EFI_ERROR(Status))
  {
    Print(L"NHS ======> Number of PCI devices found: %d\n", HandleCount);
    for (UINTN i = 0; i < HandleCount; i++)
    {
      //Print(L"TEST\n");
      //unsigned short vendorId = MY_VENDOR_ID;
      //unsigned short deviceId = MY_DEVICE_ID;
      EFI_PCI_IO_PROTOCOL* PciIo;
      EFI_DEVICE_PATH_PROTOCOL* DevicePath;
      EFI_DEVICE_PATH_PROTOCOL* Node;
      Status = gBS->HandleProtocol(Handles[i], &gEfiPciIoProtocolGuid, (VOID**)&PciIo);
      if (EFI_ERROR(Status)) {
        Print(L"NHS ======> Status Error= gBS->HandleProtocol(Handles[i], &gEfiPciIoProtocolGuid, (VOID**)&PciIo);\n");
        continue;
      }
      UINT16 VendorId, DeviceId;
      Status = PciIo->Pci.Read(PciIo, EfiPciIoWidthUint16, PCI_VENDOR_ID_OFFSET, 1, &VendorId);
      if (EFI_ERROR(Status)) {
        Print(L"NHS ======> Error reading  Vendor ID: %r\n", Status);
        continue;
      }
      Status = PciIo->Pci.Read(PciIo, EfiPciIoWidthUint16, PCI_DEVICE_ID_OFFSET, 1, &DeviceId);
      if (EFI_ERROR(Status)) {
        Print(L"NHS ======> Error reading Device ID: %r\n", Status);
        continue;
      }
      Status = gBS->HandleProtocol(Handles[i], &gEfiDevicePathProtocolGuid, (VOID**)&DevicePath);
      if (EFI_ERROR(Status)) {
        Print(L"NHS ======> Status Error = gBS->HandleProtocol(Handles[i], &gEfiDevicePathProtocolGuid, (VOID**)&DevicePath);\nStatus: %r\n", Status);
        continue;
      }
      Node = DevicePath;
      if (EFI_ERROR(Status)) {
        Print(L"NHS ======> Error Node = DevicePath: %r\n", Status);
        continue;
      }
      //DevicePath = NextDevicePathNode(DevicePath);
      if (!EFI_ERROR(Status))
      {
        //EFI_DEVICE_PATH_PCI_NODE *PciNode = (EFI_DEVICE_PATH_PCI_NODE *)Node;
        //EFI_GUID DeviceGuid
        // Get device name (PciDeviceName), DeviceID, and existing GUID (ExistingGuid)
        CHAR16* PciDeviceName = L"Unknown PCI Device";  // Replace with actual device name if available
        //UINT16 DeviceID =0xABCD;
        //EFI_GUID ExistingGuid=NULL;// = NULL;//PciNode->DevicePath.Guid;//&DevicePath->DevicePath.Guid;//->Guid;
        GUID* ExistingGuid = NULL;
        GUID* NewGuid= NULL;
        /*The EFI_RNG_PROTOCOL does not require you to explicitly specify an algorithm.
        Instead, it uses its default algorithm internally.
        Therefore, you can simply pass NULL for the RngAlgorithm parameter.*/
        EFI_RNG_PROTOCOL* RngProtocol = NULL;
        EFI_RNG_ALGORITHM* RngAlgorithm = NULL;
        GUID* guid= NULL;
        if (EFI_ERROR(Status)) {//RngProtocol Not Found
          Print(L"NHS ======> 3 (GUID* guid=NULL;) Status Error: %r\n", Status);
          break;
        }
        Status = gBS->LocateProtocol(
          &gEfiRngProtocolGuid,
          NULL,
          (VOID**)&RngProtocol
        );
        if (EFI_ERROR(Status)) {//RngProtocol Not Found
          Print(L"NHS ======> 3 Status Error: RngProtocol %r\n", Status);
          break;
        }
        if (!EFI_ERROR(Status)) {//RngProtocolFound
            Print(L"NHS ======> 3 Status: RngProtocol %r\n", Status);
          //Generate random bytes
          UINT8 randomBytes[16]; //guid is 16 Bytes
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> 4 (UINT8 randomBytes[16];) Status Error: %r\n", Status);
            continue;
          }
          Status = RngProtocol->GetRNG(RngProtocol, RngAlgorithm, sizeof(randomBytes), randomBytes);//RngProtocol, sizeof(randomBytes));
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> 4 Status Error: %r\n", Status);
            break;
          }
          if (!EFI_ERROR(Status)) {
            Print(L"NHS ======> GetRNG Status: %r\n", Status);
            continue;
          }
          // Copy random bytes to memory
          CopyMem(guid, randomBytes, sizeof(EFI_GUID));
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> 2 CopyMem Status Error: %r\n", Status);
            break;
          }
          if (!EFI_ERROR(Status)) {
            Print(L"NHS ======> 3 CopyMem Status: %r\n", Status);
            continue;
          }
          // Edit the variant and version fields in memory (required for a valid GUID)
          guid->Data3 = (guid->Data3 & 0x0FFF) | 0x4000; // Version 4 (random)
          guid->Data4[0] = (guid->Data4[0] & 0x3F) | 0x80; // Variant (RFC 4122)

          // Update the GUID (temporary change)
          CopyMem(&ExistingGuid, guid, sizeof(EFI_GUID));
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> 4 CopyMem Status Error: %r\n", Status);
            break;
          }
          // Print the modified information
          Print(L"NHS ===> Modified %s Loop Time: %g\n", PciDeviceName, &HandleCount);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> M1 Status Error: %r\n", Status);
            break;
          }
          Print(L"NHS ======> %s Name: %s\n", PciDeviceName, PciDeviceName);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> M2 Status Error: %r\n", Status);
            break;
          }
          Print(L"NHS ======> %s Device ID: 0x%X\n", PciDeviceName, &DeviceId);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> M3 Status Error: %r\n", Status);
            break;
          }
          Print(L"NHS ======> %s Vendor ID: 0x%X\n", PciDeviceName, &VendorId);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> M4 Status Error: %r\n", Status);
            break;
          }
          Print(L"NHS ===> %s Device GUID: %g\n", PciDeviceName, ExistingGuid);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> m5 Status Error: %r\n", Status);
            break;
          }
          Print(L"NHS ===> Modified %s Device GUID: %g\n", PciDeviceName, NewGuid);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> M6 Status Error: %r\n", Status);
            break;
          }
          //Finished switch to next device
          Node = NextDevicePathNode(Node);
          if (EFI_ERROR(Status)) {
            Print(L"NHS ======> M7 Status Error: %r\n", Status);
            break;
          }
          Status = gBS->Stall(Delayver);
        }
        // Save our variable from deletion
        //CopyMem(&guid, &ExistingGuid, sizeof(EFI_GUID));

        // Copy random bytes to memory
        //CopyMem(guid, randomBytes, sizeof(EFI_GUID));

        // Edit the variant and version fields in memory (required for a valid GUID)
        //guid->Data3 = (guid->Data3 & 0x0FFF) | 0x4000; // Version 4 (random)
        //guid->Data4[0] = (guid->Data4[0] & 0x3F) | 0x80; // Variant (RFC 4122)

        // Update the GUID (temporary change)
        //CopyMem(&ExistingGuid, guid, sizeof(EFI_GUID));

        // Print the modified information
        //Print(L"NHS ======> %s Name: %s\n", PciDeviceName, PciDeviceName);
        //Print(L"NHS ======> %s Device ID: 0x%X\n", PciDeviceName, DeviceId);
        //Print(L"NHS ======> %s Vendor ID: 0x%X\n", PciDeviceName, VendorId);
        //Print(L"NHS ======> Modified %s Device GUID: %g\n", PciDeviceName, &NewGuid);
        //Finished switch to next device
        //Node = NextDevicePathNode(Node);
      }
    }
  }
  Status = gBS->Stall(Delayver);
  gBS->FreePool(Handles);
  return EFI_SUCCESS;
}


