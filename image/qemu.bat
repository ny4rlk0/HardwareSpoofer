:: qemu.bat file
qemu-system-x86_64 ^
-drive format=raw,unit=0,file=test.hdd ^
-bios P4KBL.fd ^
-m 1024M ^
-display sdl ^
-vga std ^
-name (nyarlko.efi) ^
-machine q35 ^
-usb ^
-device usb-mouse ^
-rtc base=localtime ^
-net none
