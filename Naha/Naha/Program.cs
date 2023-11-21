namespace Naha
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }

        public static biere[] init_list_biere()
        {
            biere seizequatre = new biere("1664", "5.5", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/seizequatre.jfif");
            biere kro = new biere("Kronenbourg", "4.2", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/kro.jpg");
            biere tripleK = new biere("Triple karmeliet", "8.4", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/tripleK.jpg");
            biere goudale = new biere("Goudale", "7.2", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/goudale.jfif");
            biere huitsix = new biere("8.6", "8.6", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/huitsix.jpg");
            biere leffe = new biere("Leffe", "6.6", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/Images/leffe.jpg");
            biere heineken = new biere("Heineken", "5", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/heineken.jpg");
            biere despe = new biere("Desperados", "5.9", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/desperados.jpg");
            biere hoegaarden = new biere("Hoegaarden", "4.9", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/hoegaarden.jpg");
            biere guinness = new biere("Guinness", "4.2", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/guinness.jpg");
            biere corona = new biere("Corona", "4.6", "C:/Users/rpaup/Desktop/Visual Studio/Naha/Naha/Images/Bi�re/corona.jpg");
            biere[] list = new biere[] { seizequatre, kro, tripleK, goudale, huitsix, leffe, heineken, despe, hoegaarden, guinness, corona };
            return list;
        }
        public static biere choisir_biere(biere[] list)
        {
            var rdm = new Random();
            biere resul = list[rdm.Next(list.Length)];
            return resul;
        }
    }
}