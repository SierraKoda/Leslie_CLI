using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Globalization;

using System.IO;

using System.Data;

using System.Security;

using System.Security.Cryptography;

using System.Media;

using System.Web;

using System.Windows;

using System.Net.Http;

using System.Net.NetworkInformation;

using System.Net.Security;

using System.Net.WebSockets;

using System.Net.Mail;

using System.Net.Configuration;

using System.Net.Sockets;

using System.Net.Cache;









namespace LeslieCLI

{

    class Program

    {



        public string rl = "";

        public string input = "";



        static void Main(string[] args)

        {

        Start:





            System.Console.WriteLine("Welcome!");

            System.Console.WriteLine("Are You A New User Or Returning?");



            string input1 = System.Console.ReadLine();

            if (input1 == "new")

            {









                System.Console.WriteLine("Welcome! Please Input Your Username: ");

                string Usr = Console.ReadLine();

                System.Console.WriteLine("Thank You! Please Input Your Passkey Information: ");

                string Pwd = Console.ReadLine();



                //System.Console.WriteLine("Thank you! Please Input Your Password: ");

                //string Pwd = Console.ReadLine();



                byte[] UsrData = Encoding.UTF8.GetBytes(Usr);

                byte[] shaHash;

                byte[] shaPwdHash;

                SHA512 shaWoah = new SHA512Managed();

                shaHash = shaWoah.ComputeHash(UsrData);

                byte[] PwdData = Encoding.UTF8.GetBytes(Pwd);

                SHA512 shaFuckYou = new SHA512Managed();

                shaPwdHash = shaFuckYou.ComputeHash(PwdData);





                string InMy64 = Convert.ToBase64String(shaHash);

                System.Console.WriteLine(InMy64);



                string OnThat11 = Convert.ToBase64String(shaPwdHash);

                System.Console.WriteLine(OnThat11);

                //StreamWriter sw = new StreamWriter(@"C:\Users\Naye\Documents\Usrnames.txt");

                //StreamWriter sw2 = new StreamWriter(@"C:\Users\Naye\Documents\Pwds.txt");

                using (StreamWriter outputUsr = new StreamWriter(@"C:\Users\Public\Usrnames.txt", true))

                {

                    outputUsr.WriteLine(InMy64);

                }



                using (StreamWriter outputPass = new StreamWriter(@"C:\Users\Public\Pwds.txt", true))

                {

                    outputPass.WriteLine(OnThat11);

                }

                System.Console.WriteLine("Your Information Has Been Written To The File System!");



                //string HashStrArg = Encoding.UTF8.GetString(shaHash);  Cute but doesnt work quite right

                //System.Console.WriteLine(HashStrArg);   Still cute, still doesnt work mquite right....





                //Soon To Be Giant For Looping of Password Shtuff and SHA hashing fun

                //Use System.Security something...

                // Tell the nay sayers to stfu or grow thicked skin.

                // they brought this on themselves.



                string rl = "";

                string input = System.Console.ReadLine();

                rl = input;

                System.Console.WriteLine("Welcome To This Teminal Emulation Window! I Hope You Are Doing Well.");

                System.Console.WriteLine("Here Are Your Diagnostic Readings For The User's Root File System...");

                System.Console.ReadKey();



                DriveInfo dfir = new System.IO.DriveInfo(@"C:\Users\");



                string dfs = dfir.TotalFreeSpace.ToString();

                string dvl = dfir.VolumeLabel.ToString();



                System.IO.DirectoryInfo dinf = new System.IO.DirectoryInfo(@"C:\Users\");

                System.IO.FileInfo[] filnam = dinf.GetFiles("*.*");



                foreach (System.IO.FileInfo fi in filnam)

                {

                    Console.WriteLine("{0}: {1}: {2}: {3}: {4}", fi.Name, fi.LastWriteTime,

                        fi.LastAccessTime, fi.Length, fi.IsReadOnly);

                }



                System.Console.ReadLine();

                string[] newfoldnam = Directory.GetDirectories(@"C:\Users\");

                System.Collections.Generic.List<string> list = newfoldnam.ToList();



                foreach (var item in list)

                {

                    Console.WriteLine(item);

                }

                while (rl != "exit")

                {



                Prompt100:



                    string rl2 = System.Console.ReadLine();

                    rl2 = rl;

                    string path = Directory.GetCurrentDirectory();

                    System.Console.ReadLine();

                    System.Console.WriteLine("Would You Like To Open A Specific File Path Or Get A List Of Optional Commands?");

                    System.Console.WriteLine("For Options, Type 'Options' And Press Return, Otherwise Input 'Path' And Press Return.");

                    string inputline = System.Console.ReadLine();

                    if (inputline == "Options")

                    {

                        goto MenuOptions;

                    }

                    else if (inputline == "Path")

                    {

                        goto PathLine;

                    }

                    else

                    {

                        Console.WriteLine("Command Not Recognised...");

                        goto Prompt100;

                    }

                MenuOptions:

                    Console.WriteLine("Your Available Menu Options Are Among The Following Categories:");

                    Console.WriteLine("Audio ... Video ... File Directory ... Security ... GUI ... Network ... Text ... Image ... File Transfer" +

                        "... & Streaming");

                    Console.WriteLine("Please Choose A Category: ");



                    string catChoice = Console.ReadLine();

                    if (catChoice == "audio")

                    {

                        goto AudioCat;

                    }

                    else if (catChoice == "video")

                    {

                        goto VideoCat;

                    }

                    else if (catChoice == "file directory")

                    {

                        goto FileDirectoryCat;

                    }

                    else if (catChoice == "security")

                    {

                        goto SecurityCat;

                    }

                    else if (catChoice == "GUI")

                    {

                        goto GUICat;

                    }

                    else if (catChoice == "network")

                    {

                        goto NetworkCat;

                    }

                    else if (catChoice == "text")

                    {

                        goto TextCat;

                    }

                    else if (catChoice == "image")

                    {

                        goto ImageCat;

                    }

                    else if (catChoice == "file transfer")

                    {

                        goto FileTransferCat;

                    }

                    else if (catChoice == "streaming")

                    {

                        goto StreamingCat;

                    }

                    else

                    {

                        Console.WriteLine("Command Not Understood. Restarting Program Cycle Now...");

                        goto Start;

                    }

                AudioCat:

                    Console.WriteLine("Welcome To Your Section For Audio Functions Within This Command Line Terminal!");

                    Console.WriteLine("Please Type The File Path To The Song You Would Like To Play: ");

                    string songPath = Console.ReadLine();

                    SoundPlayer songPlayer = new SoundPlayer();

                    try

                    {

                        System.Console.WriteLine("Attempting Your File Now...");

                        songPlayer.Stream = File.OpenRead(@"C:\Users\" + songPath);

                        songPlayer.LoadAsync();

                        songPlayer.PlaySync();



                    }

                    catch (Exception)

                    {

                        Console.WriteLine("Your File Did Not Load Effectively. Please Check That It Is In WAV Format And Try Again!");

                        Console.WriteLine("Please Choose 'Try Again' Or Go Back To Your Options Prompt With The Command 'Options': ");

                        string audioexcom1 = Console.ReadLine();

                        if (audioexcom1 == "try again")

                        {

                            Console.WriteLine("Thank You For Your Input...");

                            goto AudioCat;

                        }

                        else if (audioexcom1 == "Options")

                        {

                            Console.WriteLine("Going Back To Your Options Menu...");

                            goto MenuOptions;

                        }

                    }





                VideoCat:

                    Console.WriteLine("Welcome To Your Section For Video Functions Within This Command Line Terminal!");

                    Console.WriteLine("Video Playback Is Currently Under Development For This Command Line Platform. Please Be Patient...");

                    goto MenuOptions;



                SecurityCat:

                    Console.WriteLine("Welcome To Your Section For Security Functions Within This Command Line Terminal!");



                FileDirectoryCat:

                    Console.WriteLine("Welcome To Your Section For File Directory Functions Within This Command Line Terminal!");

                    goto PathLine;



                GUICat:

                    Console.WriteLine("Welcome To Your Section For GUI Functions Within This Command Line Terminal!");



                NetworkCat:

                    Console.WriteLine("Welcome To Your Section For Network Functions Within This Command Line Terminal!");

                    System.Console.WriteLine("Please Wait While We Attempt To Run Some Bullshit URL....");





                TextCat:

                    Console.WriteLine("Welcome To Your Section For Text Functions Within This Command Line Terminal!");

                    Console.WriteLine("Please Input The Path To The Desired Text File: ");

                    string textPath = Console.ReadLine();

                    StreamReader textR = new StreamReader(@"C:\Users\" + textPath, true);

                    string toend = textR.ReadToEnd().ToString();

                    Console.WriteLine(toend);

                    Console.ReadKey();

                SecondRead:



                    Console.WriteLine("To Open Another Text File Type 'read more' And Press Return, Otherwise Type 'Options': ");

                    string newInput = Console.ReadLine();

                    if (newInput == "read more")

                    {

                        goto TextCat;

                    }

                    else if (newInput == "Options")

                    {

                        Console.WriteLine("Going Back To Your Option Prompt...");

                        goto MenuOptions;

                    }

                    else

                    {

                        Console.WriteLine("Command Not Recognised. Please Wait...");

                        goto SecondRead;

                    }





                ImageCat:

                    Console.WriteLine("Welcome To Your Section For Image Functions Within This Command Line Terminal!");



                FileTransferCat:

                    Console.WriteLine("Welcome To Your Section For File Transfer Functions Within This Command Line Terminal!");

                    Console.WriteLine("To Send An Email, Type 'Email' And Press Return: ");

                    string commandfort = Console.ReadLine();

                    if (commandfort == "Email")

                    {

                        goto Email;

                    }

                    else

                    {

                        goto MenuOptions;

                    }



                Email:



                    Console.WriteLine("Please Enter The Email Address To Send Mail To: ");

                    string sendmail = System.Console.ReadLine();

                    SmtpClient smclien = new SmtpClient(host: "smtp.mail.yahoo.com", port: 465);

                    MailAddress from = new MailAddress("Koda412@yahoo.com");

                    MailAddress to = new MailAddress(sendmail);

                    smclien.Credentials = new System.Net.NetworkCredential("Koda412@yahoo.com", "dart1867808");

                    MailMessage disMessage = new MailMessage(from, to);

                    System.Console.WriteLine("Please Input The Email Message To Be Sent And Press Return: ");

                    string messagebody = System.Console.ReadLine();

                    disMessage.Body = messagebody + Environment.NewLine;

                    System.Console.WriteLine("What Would You Like The Subject To Read?");

                    string messagesubj = System.Console.ReadLine();

                    disMessage.BodyEncoding = System.Text.Encoding.UTF8;

                    disMessage.Subject = messagesubj;

                    disMessage.SubjectEncoding = System.Text.Encoding.UTF8;

                    object userToken = "0";

                    smclien.SendAsync(disMessage, userToken);

                    System.Console.WriteLine("Lets See If This Email Sends...");



                    System.Console.WriteLine("Type 'Options' To Go To Previous Menu: ");

                    string newinput = System.Console.ReadLine();

                    if (newinput == "Options")

                    {

                        System.Console.WriteLine("Going To Your Options Menu...");

                        goto MenuOptions;

                    }

                    else

                    {

                        System.Console.WriteLine("Going To Start Screen Then... Enjoy.");

                        goto Start;

                    }



                StreamingCat:

                    Console.WriteLine("Welcome To Your Section For Media Streaming Functions Within This Command Line Terminal!");









                PathLine:





                    System.Console.WriteLine("What Is The Target Path Which You Would Like To Follow? ");

                    string targetDir = System.Console.ReadLine();





                    string prePath = @"C:\Users\" + targetDir;

                    if (System.IO.Directory.Exists(prePath))

                    {





                        System.IO.DirectoryInfo ndirin = new System.IO.DirectoryInfo(prePath);

                        System.IO.FileInfo[] newfilnam = ndirin.GetFiles("*.*");



                        string[] newfoldnam2 = Directory.GetDirectories(prePath);

                        System.Collections.Generic.List<string> list2 = newfoldnam2.ToList();

                        foreach (var item2 in list2)

                        {

                            Console.WriteLine(item2);

                        }



                        System.Console.ReadLine();



                        foreach (System.IO.FileInfo f2i in newfilnam)

                        {

                            Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i.Name, f2i.LastWriteTime, f2i.LastAccessTime, f2i.Length,

                                f2i.IsReadOnly);

                        }

                        Console.ReadKey();

                        System.Console.WriteLine(dvl);

                        System.Console.WriteLine(dfs);

                        System.Console.ReadLine();



                        rl = "";

                        rl = input;



                        if (rl != "exit")

                        {

                            rl = input;

                            System.Console.WriteLine("Please Wait While The Date Is Checked...");

                            DateTime dt = DateTime.Now;

                            string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                            System.Console.WriteLine(strDate);

                            System.Console.ReadLine();

                            System.Console.WriteLine("Thank You! ");

                            System.Console.WriteLine("Goodbye! ");



                        }

                        else

                        {

                            System.Console.WriteLine("Goodbye! ");



                        }



                    }

                    else if (File.Exists(prePath))

                    {



                        System.IO.DirectoryInfo ndirin3 = new System.IO.DirectoryInfo(prePath);

                        System.IO.FileInfo[] newfilnam3 = ndirin3.GetFiles("*.*");



                        string[] newfoldnam3 = Directory.GetDirectories(prePath);

                        System.Collections.Generic.List<string> list3 = newfoldnam3.ToList();

                        foreach (var item3 in list3)

                        {

                            Console.WriteLine(item3);

                        }



                        System.Console.ReadLine();



                        foreach (System.IO.FileInfo f2i2 in newfilnam3)

                        {

                            Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i2.Name, f2i2.LastWriteTime, f2i2.LastAccessTime, f2i2.Length,

                                f2i2.IsReadOnly);

                        }

                        Console.ReadKey();

                        System.Console.WriteLine(dvl);

                        System.Console.WriteLine(dfs);

                        System.Console.ReadLine();



                        rl = "";

                        rl = input;



                        if (rl != "exit")

                        {

                            rl = input;

                            System.Console.WriteLine("Please Wait While The Date Is Checked...");

                            DateTime dt = DateTime.Now;

                            string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                            System.Console.WriteLine(strDate);

                            System.Console.ReadLine();

                            System.Console.WriteLine("Thank You! ");

                            System.Console.WriteLine("Goodbye! ");



                        }

                        else

                        {

                            System.Console.WriteLine("Goodbye! ");

                        }

                    }

                    else

                    {

                        Console.WriteLine("This File Or Directory Has Yet To Be Provided...");

                        Console.WriteLine("Would You Like To Create A Folder By This Name?");



                        string answer = System.Console.ReadLine();

                        if (answer == "yes")

                        {

                            System.IO.Directory.CreateDirectory(prePath);

                            System.Console.WriteLine("You're Target Directory Is Being Created...");

                            System.Console.WriteLine("Please Wait...");

                            System.Console.WriteLine("You're Directory Has Been Created!");

                            System.IO.DirectoryInfo ndirin4 = new System.IO.DirectoryInfo(prePath);

                            System.IO.FileInfo[] newfilnam4 = ndirin4.GetFiles("*.*");



                            string[] newfoldnam4 = Directory.GetDirectories(prePath);

                            System.Collections.Generic.List<string> list4 = newfoldnam4.ToList();

                            foreach (var item4 in list4)

                            {

                                Console.WriteLine(item4);

                            }





                            foreach (System.IO.FileInfo f2i4 in newfilnam4)

                            {

                                Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i4.Name, f2i4.LastWriteTime, f2i4.LastAccessTime, f2i4.Length,

                                    f2i4.IsReadOnly);

                            }

                            System.Console.WriteLine(dvl);

                            System.Console.WriteLine(dfs);

                            System.Console.ReadLine();



                            rl = "";

                            rl = input;



                            if (rl != "exit")

                            {

                                rl = input;

                                System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                DateTime dt = DateTime.Now;

                                string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                System.Console.WriteLine(strDate);

                                System.Console.ReadLine();

                                System.Console.WriteLine("Thank You! ");

                                System.Console.WriteLine("Goodbye! ");



                            }

                            else

                            {

                                System.Console.WriteLine("Goodbye! ");



                            }

                        }

                        else

                        {

                            Console.WriteLine("Please Specify A New Directory Path; ");

                            string targetDir5 = System.Console.ReadLine();





                            string prePath5 = @"C:\Users\" + targetDir5;

                            if (System.IO.Directory.Exists(prePath))

                            {





                                System.IO.DirectoryInfo ndirin5 = new System.IO.DirectoryInfo(prePath);

                                System.IO.FileInfo[] newfilnam5 = ndirin5.GetFiles("*.*");



                                string[] newfoldnam5 = Directory.GetDirectories(prePath);

                                System.Collections.Generic.List<string> list5 = newfoldnam5.ToList();

                                foreach (var item5 in list5)

                                {

                                    Console.WriteLine(item5);

                                }



                                System.Console.ReadLine();



                                foreach (System.IO.FileInfo f2i5 in newfilnam5)

                                {

                                    Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i5.Name, f2i5.LastWriteTime, f2i5.LastAccessTime, f2i5.Length,

                                        f2i5.IsReadOnly);

                                }

                                Console.ReadKey();

                                System.Console.WriteLine(dvl);

                                System.Console.WriteLine(dfs);

                                System.Console.ReadLine();



                                rl = "";

                                rl = input;



                                if (rl != "exit")

                                {

                                    rl = input;

                                    System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                    DateTime dt = DateTime.Now;

                                    string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                    System.Console.WriteLine(strDate);

                                    System.Console.ReadLine();

                                    System.Console.WriteLine("Thank You! ");

                                    System.Console.WriteLine("Goodbye! ");



                                }

                                else

                                {

                                    System.Console.WriteLine("Goodbye! ");

                                }







                            }

                            else if (File.Exists(prePath))

                            {



                                System.IO.DirectoryInfo ndirin6 = new System.IO.DirectoryInfo(prePath);

                                System.IO.FileInfo[] newfilnam6 = ndirin6.GetFiles("*.*");



                                string[] newfoldnam6 = Directory.GetDirectories(prePath);

                                System.Collections.Generic.List<string> list6 = newfoldnam6.ToList();

                                foreach (var item6 in list6)

                                {

                                    Console.WriteLine(item6);

                                }



                                System.Console.ReadLine();



                                foreach (System.IO.FileInfo f2i26 in newfilnam6)

                                {

                                    Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i26.Name, f2i26.LastWriteTime, f2i26.LastAccessTime, f2i26.Length,

                                        f2i26.IsReadOnly);

                                }

                                Console.ReadKey();

                                System.Console.WriteLine(dvl);

                                System.Console.WriteLine(dfs);

                                System.Console.ReadLine();



                                rl = "";

                                rl = input;



                                if (rl != "exit")

                                {

                                    rl = input;

                                    System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                    DateTime dt = DateTime.Now;

                                    string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                    System.Console.WriteLine(strDate);

                                    System.Console.ReadLine();

                                    System.Console.WriteLine("Thank You! ");

                                    System.Console.WriteLine("Goodbye! ");

                                }

                                else

                                {

                                    System.Console.WriteLine("Goodbye! ");



                                }

                            }

                            else

                            {

                                Console.WriteLine("This File Or Directory Has Yet To Be Provided...");

                                Console.WriteLine("Would You Like To Create A Folder By This Name?");



                                string answer2 = System.Console.ReadLine();

                                if (answer2 == "Yes")

                                {

                                    System.IO.Directory.CreateDirectory(prePath);

                                    System.Console.WriteLine("You're Target Directory Is Being Created...");

                                    System.Console.WriteLine("Please Wait...");

                                    System.Console.WriteLine("You're Directory Has Been Created!");

                                    System.IO.DirectoryInfo ndirin47 = new System.IO.DirectoryInfo(prePath);

                                    System.IO.FileInfo[] newfilnam47 = ndirin47.GetFiles("*.*");



                                    string[] newfoldnam47 = Directory.GetDirectories(prePath);

                                    System.Collections.Generic.List<string> list47 = newfoldnam47.ToList();

                                    foreach (var item47 in list47)

                                    {

                                        Console.WriteLine(item47);

                                    }





                                    foreach (System.IO.FileInfo f2i47 in newfilnam47)

                                    {

                                        Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i47.Name, f2i47.LastWriteTime, f2i47.LastAccessTime, f2i47.Length,

                                            f2i47.IsReadOnly);

                                    }

                                    System.Console.WriteLine(dvl);

                                    System.Console.WriteLine(dfs);

                                    System.Console.ReadLine();



                                    rl = "";

                                    rl = input;



                                    if (rl != "exit")

                                    {

                                        rl = input;

                                        System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                        DateTime dt = DateTime.Now;

                                        string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                        System.Console.WriteLine(strDate);

                                        System.Console.ReadLine();

                                        System.Console.WriteLine("Thank You! ");

                                        System.Console.WriteLine("Goodbye! ");



                                    }

                                    else

                                    {

                                        System.Console.WriteLine("Goodbye! ");



                                    }

                                }

                                else

                                {



                                    Console.WriteLine("Input Failed Twice: Breaking Sequence Status");

                                    Console.ReadKey();

                                    System.Console.WriteLine(dvl);

                                    System.Console.WriteLine(dfs);

                                    System.Console.ReadKey();



                                    rl = "";

                                    rl = input;



                                    if (rl != "exit")

                                    {

                                        rl = input;
										
                                        System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                        DateTime dt = DateTime.Now;

                                        string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                        System.Console.WriteLine(strDate);

                                        System.Console.ReadLine();

                                        System.Console.WriteLine("Thank You! ");

                                        System.Console.WriteLine("Goodbye! ");





                                    }

                                    else

                                    {

                                        rl = input;

                                        System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                        DateTime dt = DateTime.Now;

                                        string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                        System.Console.WriteLine(strDate);

                                        System.Console.ReadLine();

                                        System.Console.WriteLine("Thank You! ");

                                        System.Console.WriteLine("Goodbye! ");



                                    }

















                                }





                            }









                        }



                    }



                    Console.WriteLine("Would You Like To Exit The Program? If So Please Type In 'exit' And " +

                        "Press Return. Otherwise, Hit Return Three Times!");

                    rl = Console.ReadLine();

                }

            }

            else if (input1 == "returning")

            {



            LogIn:



                System.Console.WriteLine("Welcome! Please Input Your Username: ");

                string Usr = Console.ReadLine();

                System.Console.WriteLine("Thank You! Please Input Your Passkey Information: ");

                string Pwd = Console.ReadLine();



                //System.Console.WriteLine("Thank you! Please Input Your Password: ");

                //string Pwd = Console.ReadLine();



                byte[] UsrData = Encoding.UTF8.GetBytes(Usr);

                byte[] shaHash;

                byte[] shaPwdHash;

                SHA512 shaWoah = new SHA512Managed();

                shaHash = shaWoah.ComputeHash(UsrData);

                byte[] PwdData = Encoding.UTF8.GetBytes(Pwd);

                SHA512 shaFuckYou = new SHA512Managed();

                shaPwdHash = shaFuckYou.ComputeHash(PwdData);



                string InMy64 = Convert.ToBase64String(shaHash);

                // System.Console.WriteLine(InMy64);

                string OnThat11 = Convert.ToBase64String(shaPwdHash);

                //System.Console.WriteLine(OnThat11);

                int userindexglobal = 0;

                using (StreamReader usrread = new StreamReader(@"C:\Users\Public\Usrnames.txt", true))

                {

                    string contents = usrread.ReadToEnd();

                    if (contents.Contains(InMy64))

                    {

                        System.Console.WriteLine("Thank You!");

                        goto UsrIndex;

                    }

                    else

                    {

                        Console.WriteLine("We're Sorry, Your Username Was Not Found To Be Valid.");

                        goto LogIn;

                    }

                UsrIndex:

                    userindexglobal = contents.IndexOf(InMy64);

                    goto Pass;



                }

            Pass:

                int passindexglobal = 0;

                bool usrAuth = true;

                using (StreamReader pwdread = new StreamReader(@"C:\Users\Public\Pwds.txt", true))

                {

                    string contents = pwdread.ReadToEnd();

                    if (contents.Contains(OnThat11))

                    {



                        System.Console.WriteLine("We Appreciate You Following These Security Formalities. Thank You, Once Again!");

                        goto PassIndex;

                    }

                    else

                    {

                        Console.WriteLine("We're Sorry Your Passkey Did Not Authorize.");

                        goto Start;

                    }

                PassIndex:

                    passindexglobal = contents.IndexOf(OnThat11);

                    goto Auth;

                }



            Auth:

                bool passAuth = true;



                bool doesit = usrAuth == passAuth;

                if (doesit == true && userindexglobal == passindexglobal)

                {

                    goto MainSubLoop;

                }

                else

                {

                    Console.WriteLine("Authorization Did Not Occur. Looping Cycle...");

                    goto Start;

                }







            //string HashStrArg = Encoding.UTF8.GetString(shaHash);  Cute but doesnt work quite right

            //System.Console.WriteLine(HashStrArg);   Still cute, still doesnt work mquite right....





            //Soon To Be Giant For Looping of Password Shtuff and SHA hashing fun

            //Use System.Security something...

            // Tell the nay sayers to stfu or grow thicked skin.

            // they brought this on themselves.





            MainSubLoop:



                string rl = "";

                string input = System.Console.ReadLine();

                rl = input;

                System.Console.WriteLine("Welcome To This Teminal Emulation Window! I Hope You Are Doing Well.");

                System.Console.WriteLine("Here Are Your Diagnostic Readings For The User's Root File System...");

                System.Console.ReadKey();



                DriveInfo dfir = new System.IO.DriveInfo(@"C:\Users\");



                string dfs = dfir.TotalFreeSpace.ToString();

                string dvl = dfir.VolumeLabel.ToString();



                System.IO.DirectoryInfo dinf = new System.IO.DirectoryInfo(@"C:\Users\");

                System.IO.FileInfo[] filnam = dinf.GetFiles("*.*");



                foreach (System.IO.FileInfo fi in filnam)

                {

                    Console.WriteLine("{0}: {1}: {2}: {3}: {4}", fi.Name, fi.LastWriteTime,

                        fi.LastAccessTime, fi.Length, fi.IsReadOnly);

                }



                System.Console.ReadLine();

                string[] newfoldnam = Directory.GetDirectories(@"C:\Users\");

                System.Collections.Generic.List<string> list = newfoldnam.ToList();



                foreach (var item in list)

                {

                    Console.WriteLine(item);

                }

                while (rl != "exit")

                {



                Prompt101:



                    string rl2 = System.Console.ReadLine();

                    rl2 = rl;

                    string path = Directory.GetCurrentDirectory();

                    System.Console.WriteLine("Would You Like To Open A Specific File Path Or Get A List Of Optional Commands?");

                    System.Console.WriteLine("For Options, Type 'Options' And Press Return, Otherwise Input 'Path' And Press Return.");

                    string inputline = System.Console.ReadLine();

                    if (inputline == "Options")

                    {

                        goto MenuOptions2;

                    }

                    else if (inputline == "Path")

                    {

                        goto PathLine2;

                    }

                    else

                    {

                        Console.WriteLine("Command Not Recognised...");

                        goto Prompt101;

                    }

                MenuOptions2:





                    //

                    //

                    //

                    //

                    //

                    //

                    //

                    //

                    //

                    //

                    //

                    //

                    //





                    Console.WriteLine("Your Available Menu Options Are Among The Following Categories:");

                    Console.WriteLine("Audio ... Video ... File Directory ... Security ... GUI ... Network ... Text ... Image ... File Transfer" +

                        "... & Streaming");

                    Console.WriteLine("Please Choose A Category: ");



                    string catChoice2 = Console.ReadLine();

                    if (catChoice2 == "audio")

                    {

                        goto AudioCat2;

                    }

                    else if (catChoice2 == "video")

                    {

                        goto VideoCat2;

                    }

                    else if (catChoice2 == "file directory")

                    {

                        goto FileDirectoryCat2;

                    }

                    else if (catChoice2 == "security")

                    {

                        goto SecurityCat2;

                    }

                    else if (catChoice2 == "GUI")

                    {

                        goto GUICat2;

                    }

                    else if (catChoice2 == "network")

                    {

                        goto NetworkCat2;

                    }

                    else if (catChoice2 == "text")

                    {

                        goto TextCat2;

                    }

                    else if (catChoice2 == "image")

                    {

                        goto ImageCat2;

                    }

                    else if (catChoice2 == "file transfer")

                    {

                        goto FileTransferCat2;

                    }

                    else if (catChoice2 == "streaming")

                    {

                        goto StreamingCat2;

                    }

                    else

                    {

                        Console.WriteLine("Command Not Understood. Restarting Program Cycle Now...");

                        goto Start;

                    }

                AudioCat2:

                    Console.WriteLine("Welcome To Your Section For Audio Functions Within This Command Line Terminal!");

                    Console.WriteLine("Please Type The File Path To The Song You Would Like To Play: ");

                    string songPath2 = Console.ReadLine();

                    SoundPlayer songPlayer2 = new SoundPlayer();

                    try

                    {

                        System.Console.WriteLine("Attempting To Load Your File Now...");

                        songPlayer2.Stream = File.OpenRead(@"C:\Users\" + songPath2);

                        songPlayer2.LoadAsync();

                        songPlayer2.PlaySync();



                    }

                    catch (Exception)

                    {

                        Console.WriteLine("Your File Did Not Load Effectively. Please Check That It Is In WAV Format And Try Again!");

                        Console.WriteLine("Please Choose 'Try Again' Or Go Back To Your Options Prompt With The Command 'Options': ");

                        string audioexcom = Console.ReadLine();

                        if (audioexcom == "try again")

                        {

                            Console.WriteLine("Thank You For Your Input...");

                            goto AudioCat2;

                        }

                        else if (audioexcom == "Options")

                        {

                            Console.WriteLine("Going Back To Your Options Menu...");

                            goto MenuOptions2;

                        }



                    }



                VideoCat2:

                    Console.WriteLine("Welcome To Your Section For Video Functions Within This Command Line Terminal!");

                    Console.WriteLine("Video Playback Is Currently Under Construction For This Command Line Program. Please Be Patient!");

                    goto MenuOptions2;



                SecurityCat2:

                    Console.WriteLine("Welcome To Your Section For Security Functions Within This Command Line Terminal!");



                FileDirectoryCat2:

                    Console.WriteLine("Welcome To Your Section For File Directory Functions Within This Command Line Terminal!");

                    goto PathLine2;



                GUICat2:

                    Console.WriteLine("Welcome To Your Section For GUI Functions Within This Command Line Terminal!");



                NetworkCat2:

                    Console.WriteLine("Welcome To Your Section For Network Functions Within This Command Line Terminal!");

                    Console.WriteLine("Welcome To Your Section For File Transfer Functions Within This Command Line Terminal!");

                    Console.WriteLine("To Send An Email, Type 'Email' And Press Return: ");

                    string commandfort2 = Console.ReadLine();

                    if (commandfort2 == "Email")

                    {

                        goto Email;

                    }

                    else

                    {

                        goto MenuOptions2;

                    }



                Email:



                    Console.WriteLine("Please Enter The Email Address To Send Mail To: ");

                    string sendmail2 = System.Console.ReadLine();

                    SmtpClient smclien2 = new SmtpClient(host: "smtp.mail.yahoo.com", port: 465);

                    MailAddress from2 = new MailAddress("Koda412@yahoo.com");

                    smclien2.Credentials = new System.Net.NetworkCredential("Koda412@yahoo.com", "dart1867808");

                    MailAddress to2 = new MailAddress(sendmail2);

                    MailMessage disMessage2 = new MailMessage(from2, to2);

                    System.Console.WriteLine("Please Input The Email Message To Be Sent And Press Return: ");

                    string messagebody2 = System.Console.ReadLine();

                    disMessage2.Body = messagebody2 + Environment.NewLine;

                    System.Console.WriteLine("What Would You Like The Subject To Read?");

                    string messagesubj2 = System.Console.ReadLine();

                    disMessage2.BodyEncoding = System.Text.Encoding.UTF8;

                    disMessage2.Subject = messagesubj2;

                    disMessage2.SubjectEncoding = System.Text.Encoding.UTF8;

                    object userToken = "0";

                    smclien2.SendAsync(disMessage2, userToken);



                    System.Console.WriteLine("Lets See If This Email Sends...");

                    System.Console.WriteLine("Type 'Options' To Go To Previous Menu: ");

                    string newinput2 = System.Console.ReadLine();

                    if (newinput2 == "Options")

                    {

                        System.Console.WriteLine("Going To Your Options Menu...");

                        goto MenuOptions2;

                    }

                    else

                    {

                        System.Console.WriteLine("Going To Start Screen Then... Enjoy.");

                        goto Start;

                    }



                TextCat2:

                    Console.WriteLine("Welcome To Your Section For Text Functions Within This Command Line Terminal!");

                    Console.WriteLine("Please Input The Path To The Desired Text File: ");

                    string textPath = Console.ReadLine();

                    StreamReader textR = new StreamReader(@"C:\Users\" + textPath, true);

                    string toend = textR.ReadToEnd().ToString();

                    Console.WriteLine(toend);

                    Console.ReadKey();

                SecondRead2:



                    Console.WriteLine("To Open Another Text File Type 'read more' And Press Return, Otherwise Type 'Options': ");

                    string newInput2 = Console.ReadLine();

                    if (newInput2 == "read more")

                    {

                        goto TextCat2;

                    }

                    else if (newInput2 == "Options")

                    {

                        Console.WriteLine("Going Back To Your Option Prompt...");

                        goto MenuOptions2;

                    }

                    else

                    {

                        Console.WriteLine("Command Not Recognised. Please Wait...");

                        goto SecondRead2;

                    }





                ImageCat2:

                    Console.WriteLine("Welcome To Your Section For Image Functions Within This Command Line Terminal!");



                FileTransferCat2:

                    Console.WriteLine("Welcome To Your Section For File Transfer Functions Within This Command Line Terminal!");



                StreamingCat2:

                    Console.WriteLine("Welcome To Your Section For Media Streaming Functions Within This Command Line Terminal!");











                PathLine2:

                    System.Console.ReadLine();

                    System.Console.WriteLine("What Is The Target Path Which You Would Like To Follow? ");

                    string targetDir = System.Console.ReadLine();





                    string prePath = @"C:\Users\" + targetDir;

                    if (System.IO.Directory.Exists(prePath))

                    {





                        System.IO.DirectoryInfo ndirin = new System.IO.DirectoryInfo(prePath);

                        System.IO.FileInfo[] newfilnam = ndirin.GetFiles("*.*");



                        string[] newfoldnam2 = Directory.GetDirectories(prePath);

                        System.Collections.Generic.List<string> list2 = newfoldnam2.ToList();

                        foreach (var item2 in list2)

                        {

                            Console.WriteLine(item2);

                        }



                        System.Console.ReadLine();



                        foreach (System.IO.FileInfo f2i in newfilnam)

                        {

                            Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i.Name, f2i.LastWriteTime, f2i.LastAccessTime, f2i.Length,

                                f2i.IsReadOnly);

                        }

                        Console.ReadKey();

                        System.Console.WriteLine(dvl);

                        System.Console.WriteLine(dfs);

                        System.Console.ReadLine();



                        rl = "";

                        rl = input;



                        if (rl != "exit")

                        {

                            rl = input;

                            System.Console.WriteLine("Please Wait While The Date Is Checked...");

                            DateTime dt = DateTime.Now;

                            string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                            System.Console.WriteLine(strDate);

                            System.Console.ReadLine();

                            System.Console.WriteLine("Thank You! ");

                            System.Console.WriteLine("Goodbye! ");



                        }

                        else

                        {

                            System.Console.WriteLine("Goodbye! ");



                        }



                    }

                    else if (File.Exists(prePath))

                    {



                        System.IO.DirectoryInfo ndirin3 = new System.IO.DirectoryInfo(prePath);

                        System.IO.FileInfo[] newfilnam3 = ndirin3.GetFiles("*.*");



                        string[] newfoldnam3 = Directory.GetDirectories(prePath);

                        System.Collections.Generic.List<string> list3 = newfoldnam3.ToList();

                        foreach (var item3 in list3)

                        {

                            Console.WriteLine(item3);

                        }



                        System.Console.ReadLine();



                        foreach (System.IO.FileInfo f2i2 in newfilnam3)

                        {

                            Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i2.Name, f2i2.LastWriteTime, f2i2.LastAccessTime, f2i2.Length,

                                f2i2.IsReadOnly);

                        }

                        Console.ReadKey();

                        System.Console.WriteLine(dvl);

                        System.Console.WriteLine(dfs);

                        System.Console.ReadLine();



                        rl = "";

                        rl = input;



                        if (rl != "exit")

                        {

                            rl = input;

                            System.Console.WriteLine("Please Wait While The Date Is Checked...");

                            DateTime dt = DateTime.Now;

                            string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                            System.Console.WriteLine(strDate);

                            System.Console.ReadLine();

                            System.Console.WriteLine("Thank You! ");

                            System.Console.WriteLine("Goodbye! ");



                        }

                        else

                        {

                            System.Console.WriteLine("Goodbye! ");

                        }

                    }

                    else

                    {

                        Console.WriteLine("This File Or Directory Has Yet To Be Provided...");

                        Console.WriteLine("Would You Like To Create A Folder By This Name?");



                        string answer = System.Console.ReadLine();

                        if (answer == "yes")

                        {

                            System.IO.Directory.CreateDirectory(prePath);

                            System.Console.WriteLine("You're Target Directory Is Being Created...");

                            System.Console.WriteLine("Please Wait...");

                            System.Console.WriteLine("You're Directory Has Been Created!");

                            System.IO.DirectoryInfo ndirin4 = new System.IO.DirectoryInfo(prePath);

                            System.IO.FileInfo[] newfilnam4 = ndirin4.GetFiles("*.*");



                            string[] newfoldnam4 = Directory.GetDirectories(prePath);

                            System.Collections.Generic.List<string> list4 = newfoldnam4.ToList();

                            foreach (var item4 in list4)

                            {

                                Console.WriteLine(item4);

                            }





                            foreach (System.IO.FileInfo f2i4 in newfilnam4)

                            {

                                Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i4.Name, f2i4.LastWriteTime, f2i4.LastAccessTime, f2i4.Length,

                                    f2i4.IsReadOnly);

                            }

                            System.Console.WriteLine(dvl);

                            System.Console.WriteLine(dfs);

                            System.Console.ReadLine();



                            rl = "";

                            rl = input;



                            if (rl != "exit")

                            {

                                rl = input;

                                System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                DateTime dt = DateTime.Now;

                                string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                System.Console.WriteLine(strDate);

                                System.Console.ReadLine();

                                System.Console.WriteLine("Thank You! ");

                                System.Console.WriteLine("Goodbye! ");



                            }

                            else

                            {

                                System.Console.WriteLine("Goodbye! ");



                            }

                        }

                        else

                        {

                            Console.WriteLine("Please Specify A New Directory Path; ");

                            string targetDir5 = System.Console.ReadLine();





                            string prePath5 = @"C:\Users\" + targetDir5;

                            if (System.IO.Directory.Exists(prePath))

                            {





                                System.IO.DirectoryInfo ndirin5 = new System.IO.DirectoryInfo(prePath);

                                System.IO.FileInfo[] newfilnam5 = ndirin5.GetFiles("*.*");



                                string[] newfoldnam5 = Directory.GetDirectories(prePath);

                                System.Collections.Generic.List<string> list5 = newfoldnam5.ToList();

                                foreach (var item5 in list5)

                                {

                                    Console.WriteLine(item5);

                                }



                                System.Console.ReadLine();



                                foreach (System.IO.FileInfo f2i5 in newfilnam5)

                                {

                                    Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i5.Name, f2i5.LastWriteTime, f2i5.LastAccessTime, f2i5.Length,

                                        f2i5.IsReadOnly);

                                }

                                Console.ReadKey();

                                System.Console.WriteLine(dvl);

                                System.Console.WriteLine(dfs);

                                System.Console.ReadLine();



                                rl = "";

                                rl = input;



                                if (rl != "exit")

                                {

                                    rl = input;

                                    System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                    DateTime dt = DateTime.Now;

                                    string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                    System.Console.WriteLine(strDate);

                                    System.Console.ReadLine();

                                    System.Console.WriteLine("Thank You! ");

                                    System.Console.WriteLine("Goodbye! ");



                                }

                                else

                                {

                                    System.Console.WriteLine("Goodbye! ");

                                }



                            }

                            else if (File.Exists(prePath))

                            {



                                System.IO.DirectoryInfo ndirin6 = new System.IO.DirectoryInfo(prePath);

                                System.IO.FileInfo[] newfilnam6 = ndirin6.GetFiles("*.*");



                                string[] newfoldnam6 = Directory.GetDirectories(prePath);

                                System.Collections.Generic.List<string> list6 = newfoldnam6.ToList();

                                foreach (var item6 in list6)

                                {

                                    Console.WriteLine(item6);

                                }



                                System.Console.ReadLine();



                                foreach (System.IO.FileInfo f2i26 in newfilnam6)

                                {

                                    Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i26.Name, f2i26.LastWriteTime, f2i26.LastAccessTime, f2i26.Length,

                                        f2i26.IsReadOnly);

                                }

                                Console.ReadKey();

                                System.Console.WriteLine(dvl);

                                System.Console.WriteLine(dfs);

                                System.Console.ReadLine();



                                rl = "";

                                rl = input;



                                if (rl != "exit")

                                {

                                    rl = input;

                                    System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                    DateTime dt = DateTime.Now;

                                    string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                    System.Console.WriteLine(strDate);

                                    System.Console.ReadLine();

                                    System.Console.WriteLine("Thank You! ");

                                    System.Console.WriteLine("Goodbye! ");

                                }

                                else

                                {

                                    System.Console.WriteLine("Goodbye! ");



                                }

                            }

                            else

                            {

                                Console.WriteLine("This File Or Directory Has Yet To Be Provided...");

                                Console.WriteLine("Would You Like To Create A Folder By This Name?");



                                string answer2 = System.Console.ReadLine();

                                if (answer2 == "Yes")

                                {

                                    System.IO.Directory.CreateDirectory(prePath);

                                    System.Console.WriteLine("You're Target Directory Is Being Created...");

                                    System.Console.WriteLine("Please Wait...");

                                    System.Console.WriteLine("You're Directory Has Been Created!");

                                    System.IO.DirectoryInfo ndirin47 = new System.IO.DirectoryInfo(prePath);

                                    System.IO.FileInfo[] newfilnam47 = ndirin47.GetFiles("*.*");



                                    string[] newfoldnam47 = Directory.GetDirectories(prePath);

                                    System.Collections.Generic.List<string> list47 = newfoldnam47.ToList();

                                    foreach (var item47 in list47)

                                    {

                                        Console.WriteLine(item47);

                                    }





                                    foreach (System.IO.FileInfo f2i47 in newfilnam47)

                                    {

                                        Console.WriteLine("{0}: {1}: {2}: {3}: {4}", f2i47.Name, f2i47.LastWriteTime, f2i47.LastAccessTime, f2i47.Length,

                                            f2i47.IsReadOnly);

                                    }

                                    System.Console.WriteLine(dvl);

                                    System.Console.WriteLine(dfs);

                                    System.Console.ReadLine();



                                    rl = "";

                                    rl = input;



                                    if (rl != "exit")

                                    {

                                        rl = input;

                                        System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                        DateTime dt = DateTime.Now;

                                        string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                        System.Console.WriteLine(strDate);

                                        System.Console.ReadLine();

                                        System.Console.WriteLine("Thank You! ");

                                        System.Console.WriteLine("Goodbye! ");



                                    }

                                    else

                                    {

                                        System.Console.WriteLine("Goodbye! ");



                                    }

                                }

                                else

                                {



                                    Console.WriteLine("Input Failed Twice: Breaking Sequence Status");

                                    Console.ReadKey();

                                    System.Console.WriteLine(dvl);

                                    System.Console.WriteLine(dfs);

                                    System.Console.ReadKey();



                                    rl = "";

                                    rl = input;



                                    if (rl != "exit")

                                    {

                                        rl = input;

                                        System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                        DateTime dt = DateTime.Now;

                                        string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                        System.Console.WriteLine(strDate);

                                        System.Console.ReadLine();

                                        System.Console.WriteLine("Thank You! ");

                                        System.Console.WriteLine("Goodbye! ");





                                    }

                                    else

                                    {

                                        rl = input;

                                        System.Console.WriteLine("Please Wait While The Date Is Checked...");

                                        DateTime dt = DateTime.Now;

                                        string strDate = dt.ToString("MM/dd/yyyy HH:mm");

                                        System.Console.WriteLine(strDate);

                                        System.Console.ReadLine();

                                        System.Console.WriteLine("Thank You! ");

                                        System.Console.WriteLine("Goodbye! ");



                                    }





                                }





                            }





                        }



                    }



                    Console.WriteLine("Would You Like To Exit The Program? If So Please Type In 'exit' And " +

                        "Press Return. Otherwise, Hit Return Three Times!");

                    rl = Console.ReadLine();

                }

            }

            else

            {

                System.Console.WriteLine("We Apologize, However Your Input Did Not Hash Appropriately.");

                System.Console.WriteLine("Error Code: 808-903672000");

                goto Start;



            }

            return;

        }

    }

}