
int foo(int x) {
  int res = 0;

  if (x % 2 == 0) {
    res += x / 2;
  } else {
    res += x / 2 + 1;
  }

  return res;
}