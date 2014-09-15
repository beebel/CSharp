 //Problem 2.   Print Company Information

 //A company has name, address, phone number, fax number, web site and manager. The manager has first name,
 //last name, age and a phone number. Write a program that reads the information about a company and its manager 
 //and prints it back on the console.

 //         program	                user
 //         Company name:	        Software University
 //         Company address:	    26 V. Kanchev, Sofia
 //         Phone number:	        +359 899 55 55 92
 //         Fax number:	
 //         Web site:	            http://softuni.bg
 //         Manager first name:	    Svetlin
 //         Manager last name:	    Nakov
 //         Manager age:	        25
 //         Manager phone:	        +359 2 981 981

 //         Software University
 //         Address: 26 V. Kanchev, Sofia
 //         Tel. +359 899 55 55 92
 //         Fax: (no fax)
 //         Web site: http://softuni.bg
 //         Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Title = "02. Print Company Information";
            Console.Write("Please enter the name of the company: ");
            string companyName = Console.ReadLine();
            Console.Write("Please enter company's address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Please enter the company's phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Please enter the company's fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Please enter the company's web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Please enter the manager's first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Please enter the manager's second name: ");
            string managerSecondName = Console.ReadLine();
            Console.Write("Please enter the manager's age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Please enter the manager's phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("\n{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhone);
            Console.WriteLine("Fax: {0}", companyFax);
            Console.WriteLine("Web site: {0}", companyWebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})\n", managerFirstName, managerSecondName, 
                                                                         managerAge, managerPhone);
        }  
    }

