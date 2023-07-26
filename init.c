#include <stdio.h>

__attribute__((export_name("entry")))
int entry(int argc, char** argv) {
	printf("init\n");
	return 0;
}