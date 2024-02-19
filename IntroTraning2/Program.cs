// See https://aka.ms/new-console-template for more information

using IntroTraning2.Entities;

CorpareCustomer corparecustomer1 = new CorpareCustomer();

corparecustomer1.Id= 1;
corparecustomer1.CustomerName = "aa";
corparecustomer1.TaxNumber = 1;

IndividualCustomer individualCustomer1 = new IndividualCustomer();

individualCustomer1.Id= 1;
individualCustomer1.CustomerName = "bb";
individualCustomer1.NationalIdentityId = 1;


BaseCustomer[] customers= {corparecustomer1, individualCustomer1};

for(int i = 0; i < customers.Length; i++)
{
    Console.WriteLine(customers[i].CustomerName);
}
