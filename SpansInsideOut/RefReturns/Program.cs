﻿var calculatedDeliveryDate = new DateTime(2022, 5, 10);
var desiredDeliveryDate = new DateTime(2012, 5, 20);

// This is "old-style". Passing DateTime values around means copying memory.
DateTime GetDeliveryDateByValue(DateTime calc, DateTime desired)
{
    if (calc < desired)
    {
        return desired;
    }
    else
    {
        return calc;
    }
}

Console.WriteLine(GetDeliveryDateByValue(
    calculatedDeliveryDate,
    desiredDeliveryDate));

// This is "new-style". Passing and returning DateTime values by reference does not need to copy memory.
ref DateTime GetDeliveryDateByRef(ref DateTime calc, ref DateTime desired)
{
    if (calc < desired)
    {
        return ref desired;
    }
    else
    {
        return ref calc;
    }
}

Console.WriteLine(GetDeliveryDateByRef(
    ref calculatedDeliveryDate,
    ref desiredDeliveryDate));

// Example for writing to the returned reference
var tictactoeBoard = string.Empty.PadLeft(9, '_').ToCharArray();
ref char GetElement(int x, int y) => ref tictactoeBoard[y * 3 + x];
GetElement(1, 1) = 'X';
Console.WriteLine(tictactoeBoard);
