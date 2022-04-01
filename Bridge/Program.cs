using Bridge;

Log logCustomer = new Customer(new CustomerLog());
logCustomer.LogWrite();


System.Console.WriteLine();


Log logFirm = new Firm(new FirmLog());
logFirm.LogWrite();
