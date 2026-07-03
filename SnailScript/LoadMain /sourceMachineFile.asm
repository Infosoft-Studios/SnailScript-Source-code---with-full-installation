section .maindata:
	mov rax, 3
	mov edx, 2
	SECTIONCONTROL:		db 0x005f

section returnentry:
	ret 0
