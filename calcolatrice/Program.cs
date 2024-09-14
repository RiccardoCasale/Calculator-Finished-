using calcolatrice.classes;
using System.Security.Cryptography.X509Certificates;

namespace calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Calcolatrice calc = new Calcolatrice();

            do
            {
                Console.WriteLine("Che operazione vuoi eseguire? +/-/X/:\n" +
                    "Se invece vuoi effettuare una radice quadrata premi /SQUARE ROOT/ \n" +
                    "Per effettuare una potenza premi /POWD/\n" + 
                    "Oppure vuoi effettuare una operazione con più di 2 cifre? Se si digita /complex/ \n" +
                    "Altrimenti digita exit");

                string operazione = Console.ReadLine();

                switch (operazione)
                {
                    case "+":

                        try
                        {
                            Console.WriteLine("Inserisci il primo numero.");
                            string numeroUno = Console.ReadLine();
                            Console.WriteLine("Inserisci il secondo numero.");
                            string numeroDue = Console.ReadLine();
                            double numUno = Convert.ToDouble(numeroUno);
                            double numDue = Convert.ToDouble(numeroDue);

                            Console.WriteLine($"Il risultato è {numUno + numDue}");
                        }
                        catch (Exception ex)
                        { 
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "-":

                        try
                        {
                            Console.WriteLine("Inserisci il primo numero.");
                            string numeroUno = Console.ReadLine();
                            Console.WriteLine("Inserisci il secondo numero.");
                            string numeroDue = Console.ReadLine();
                            double numUno = Convert.ToDouble(numeroUno);
                            double numDue = Convert.ToDouble(numeroDue);

                            Console.WriteLine($"Il risultato è {numUno - numDue}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "X":

                        try
                        {
                            Console.WriteLine("Inserisci il primo numero.");
                            string numeroUno = Console.ReadLine();
                            Console.WriteLine("Inserisci il secondo numero.");
                            string numeroDue = Console.ReadLine();
                            double numUno = Convert.ToDouble(numeroUno);
                            double numDue = Convert.ToDouble(numeroDue);

                            Console.WriteLine($"Il risultato è {numUno * numDue}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case ":":

                        try
                        {
                            Console.WriteLine("Inserisci il primo numero.");
                            string numeroUno = Console.ReadLine();
                            Console.WriteLine("Inserisci il secondo numero.");
                            string numeroDue = Console.ReadLine();
                            double numUno = Convert.ToDouble(numeroUno);
                            double numDue = Convert.ToDouble(numeroDue);

                            //AIUTAMI GIOVANNI PLS! QUESTO TERNARIO NON FUNZIONA E NON CAPISCO WHY! THANK YOU
                            //   numDue != 0 ? Console.WriteLine($"Il risultato è {numUno / numDue}"): throw new Exception(); 

                            if (numDue != 0)
                            {
                                Console.WriteLine($"Il risultato è {numUno / numDue}");
                            }
                            else
                                throw new ArgumentException();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                        //OPERAZIONI A PIU CIFRE
                    case ("complex"):

                        Console.WriteLine("Che operazione vuoi eseguire ? +/ -/ X /:");
                        string operazioneAPiuCifre = Console.ReadLine();

                        switch (operazioneAPiuCifre)
                        {
                            case "+":

                                try
                                {
                                    Console.WriteLine("Con quanti numeri vuoi fare l'addizione?");
                                    int numeroNumeri = Convert.ToInt32(Console.ReadLine());
                                    double[] numeriOperazione = new double[numeroNumeri];
                                    Console.WriteLine("Inserisci una alla volta i numeri da sommare:");
                                    for (int i = 0; i < numeriOperazione.Length; i++)
                                    {
                                        numeriOperazione[i] = Convert.ToDouble(Console.ReadLine());
                                    }
                                    Console.WriteLine(Calcolatrice.Somma(numeriOperazione));
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Errore di inserimento");
                                }

                                break; 
                            
                            case "-":

                                Console.WriteLine("Con quanti numeri vuoi fare la sottrazione? ");
                                try
                                {
                                    int numeriDaSottrarre = Convert.ToInt32(Console.ReadLine());
                                    double[] numeriSottrazione = new double[numeriDaSottrarre];
                                    Console.WriteLine("Inserisci una alla volta i numeri da sottrarre:\n Tieni presenta che i numeri successivi al primo verranno sequenzialmente sottratti da quest'ultimo.");
                                    for (int i = 0; i < numeriSottrazione.Length; i++)
                                    {
                                        numeriSottrazione[i] = Convert.ToDouble(Console.ReadLine());
                                    }

                                    Console.WriteLine(Calcolatrice.Sottrazione(numeriSottrazione));
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Errore di inserimento");
                                }

                                break;

                            case "X":

                                try
                                {
                                    Console.WriteLine("Quanti numeri vuoi moltiplicare? :");
                                    int numeroNumeriDaMoltiplicare = Convert.ToInt32(Console.ReadLine());
                                    double[] numeriDaMoltiplicare = new double[numeroNumeriDaMoltiplicare];
                                    Console.WriteLine("Inserisci una alla volta i numeri da moltiplicare. \nTieni presente che il primo numero verrà moltiplicato sequenzialmente per tutti i numeri successivi.");
                                    for (int i = 0; i < numeriDaMoltiplicare.Length; i++)
                                    {
                                        numeriDaMoltiplicare[i] = Convert.ToDouble(Console.ReadLine());
                                    }
                                    Console.WriteLine(Calcolatrice.Moltiplicazione(numeriDaMoltiplicare));
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Errore di inserimento");
                                }

                                break;

                            case ":":

                                try
                                {
                                    Console.WriteLine("Quanti numeri vuoi dividere? :");
                                    int numeroNumeriDaDividere = Convert.ToInt32(Console.ReadLine());
                                    double[] numeriDaDividere = new double[numeroNumeriDaDividere];
                                    Console.WriteLine("Inserisci una alla volta i numeri da dividere. \nTieni presente che il primo numero verrà diviso sequenzialmente per tutti i numeri successivi.");
                                    for (int i = 0; i < numeriDaDividere.Length; i++)
                                    {
                                        numeriDaDividere[i] = Convert.ToDouble(Console.ReadLine());
                                    }
                                    Console.WriteLine(Calcolatrice.Divisione(numeriDaDividere));
                                }
                                catch (Exception ex) 
                                {
                                    Console.WriteLine("Errore di inserimento");
                                }

                                break;

                            default:
                                Console.WriteLine("Mi prendi in giro? Scrivi qualcosa di sensato per favore");
                                break;
                        }


                        break;

                    case "POWD":

                                            try
                                            {
                                                Console.WriteLine("Inserisci il numero che vuoi elevare a potenza:");
                                                double numeroDaElevare = Convert.ToDouble(Console.ReadLine());
                                                Console.WriteLine("Inserisci la potenza:");
                                                double potenza = Convert.ToDouble(Console.ReadLine());

                                                Console.WriteLine(Math.Pow(numeroDaElevare, potenza));
                                            }
                                        catch(Exception ex)
                                        {
                                            Console.WriteLine("Errore di inserimento");
                                        }

                        break;

                    case "SQUARE ROOT":

                        try
                        {
                            Console.WriteLine("Inserisci il numero di cui vuoi la radice:");
                            double numeroDaCuiEstrarreLaRadice = Convert.ToDouble(Console.ReadLine());

                            if (numeroDaCuiEstrarreLaRadice < 0)
                            {
                                Console.WriteLine("Errore, radicando negativo.");
                            }
                            Console.WriteLine(Math.Sqrt(numeroDaCuiEstrarreLaRadice));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Errore di inserimento");
                        }

                        break;

                    case "exit":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Mi prendi in giro? Scrivi qualcosa di sensato per favore");
                        break;
                }




            } while (!exit);


            
        }
    }
}
