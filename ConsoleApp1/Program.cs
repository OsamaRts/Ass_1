Console.WriteLine("client type enter");
string clientType = Convert.ToString(Console.ReadLine());

Console.WriteLine("input invoice value");
double invoiceValue = Convert.ToDouble(Console.ReadLine());

double discount = 0;
double discountAmount = 0;


switch (clientType)
{
    case "Gold":
        discount = 0.20;
        discountAmount = 0.05;
        break;

    case "Silver":

        discount = 0.10;
        discountAmount = 0.03;
        break;

    case "Regular":
        discount = 0.05;
        discountAmount = 0.02;
        break;


    default:
        Console.WriteLine("invalid client type");
        break;
}


if (invoiceValue < 100)
{

    // قيمة الخصم بالدينار
    double total = invoiceValue * discount;

    // السعر النهائي
    double finalPrice = invoiceValue - total;

    // العرض
    Console.WriteLine($"total: {total} Jo ");
    Console.WriteLine($"finalPrice: {finalPrice} Jo ");

}
else if (invoiceValue > 100)
{

    discount = discount + discountAmount;

    double total = invoiceValue * discount;
    double finalPrice = invoiceValue - total;

    Console.WriteLine($"total: {total} Jo");
    Console.WriteLine($"finalPrice: {finalPrice} Jo");
}


