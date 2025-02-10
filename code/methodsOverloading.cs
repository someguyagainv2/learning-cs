static int AddValues(int x, int y) {
  return x+y;
}

static double AddValues(double x, double y) {
  return x+y;
}

int returnOverloadedFirst = AddValues(1,3);
double returnOverloadedSecond = AddValues(5.09, 2.01);

Console.WriteLine(returnOverloadedFirst);
Console.WriteLine(returnOverloadedSecond);
