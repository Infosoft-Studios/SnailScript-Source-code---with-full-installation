section .getdata:
	MOV RAX, 9
	int 0x0045f
	MOV RDX; 3

; Create multiple Int compilers
_start
	int 0x0005fd
	int 0x0003fd
	int 0x0001fd
	ret
