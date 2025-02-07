int[] myNumbers2 = {1, 2, 3};
try {
  Console.WriteLine(myNumbers2[78]);
}
catch (IndexOutOfRangeException e) {
  Console.WriteLine(e.GetType());
}
