#include "my_lib.h"
#include <stdio.h>

int main(int args, char *argv[]) {

  int res = 0;
  int x = 5;
  res = foo(x);

  printf("Hello \n");
  return res;
};