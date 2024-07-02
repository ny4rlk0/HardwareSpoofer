@echo off&&color a&&cls
echo Baseboard:&&wmic baseboard get serialnumber
echo Mac:&&wmic path Win32_NetworkAdapter where "PNPDeviceID like '%%PCI%%' AND NetConnectionStatus=2 AND AdapterTypeID='0'" get MacAddress
echo CPU:&&wmic cpu get processorid
echo GPU:&&wmic PATH Win32_VideoController GET Description,PNPDeviceID
echo DISK DRIVE:&&wmic diskdrive get serialnumber
echo MotherBoard:&&wmic baseboard get serialnumber
echo RAM:&&wmic memorychip get serialnumber
echo Bios:&&wmic bios get serialnumber
echo smBios:&&wmic csproduct get uuid&&pause