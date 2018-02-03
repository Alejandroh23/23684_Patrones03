using System;

namespace Patrones02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NumberF numberField = new NumberF("65473828484", new NumberBehavior());
            numberField.validate();
            Console.Write(numberField.getIsValid());

            numberField.setValue("4FA3B1C7D7F");
            numberField.validate();
            Console.Write(numberField.getIsValid());

            EmailF emailField = new EmailF("coachalexherrera23@gmail.com", new EmailBehavior());
            emailField.validate();
            Console.Write(emailField.getIsValid());

            emailField.setValue("ASDFGHJKLÑZXCVBN-QWERTYUIO*+_-.,--@");
            emailField.validate();
            Console.Write(emailField.getIsValid());

            PhoneFphoneField = new PhoneF("(664)2883842", new PhoneBehavior());
            phoneField.validate();
            Console.Write(phoneField.getIsValid());

            phoneField.setValue("(***-***-**-**)");
            phoneField.validate();
            Console.Write(phoneField.getIsValid());
        }
    }
}