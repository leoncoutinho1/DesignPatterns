using System;

namespace DesignPatterns
{
    public class PatternObserver {

        static void Main() {
            CNN canalcnn = new CNN();
            BBC canalbbc = new BBC();
            G1 canalg1 = new G1();
            
            var meteorologia = new Subject();

            string temperaturaAtual = meteorologia.MedeTemperatura();

            Console.WriteLine("\n<----------------------\n");
            canalbbc.Publicar(temperaturaAtual);
            canalcnn.Publicar(temperaturaAtual);
            canalg1.Publicar(temperaturaAtual);
            Console.WriteLine("\n<----------------------\n");
            
            temperaturaAtual = meteorologia.MedeTemperatura();

            R7 canalr7 = new R7();

            Console.WriteLine("\n<----------------------\n");
            canalbbc.Publicar(temperaturaAtual);
            canalr7.Publicar(temperaturaAtual);
            canalg1.Publicar(temperaturaAtual);
            Console.WriteLine("\n<----------------------\n");

            temperaturaAtual = meteorologia.MedeTemperatura();

            Console.WriteLine("\n<----------------------\n");
            canalcnn.Publicar(temperaturaAtual);
            canalr7.Publicar(temperaturaAtual);
            canalg1.Publicar(temperaturaAtual);
            Console.WriteLine("\n<----------------------\n");

        }
        
        // static void Main() {
        //     var meteorologia = new Subject();

        //     CNN canalcnn = new CNN();
        //     meteorologia.Attach(canalcnn);

        //     BBC canalbbc = new BBC();
        //     meteorologia.Attach(canalbbc);

        //     G1 canalg1 = new G1();
        //     meteorologia.Attach(canalg1);
        //     Console.WriteLine("\n<----------------------\n");
        //     meteorologia.MedeTemperatura();
        //     Console.WriteLine("\n<----------------------\n");
        //     meteorologia.MedeTemperatura();
        //     Console.WriteLine("\n<----------------------\n");
        //     meteorologia.MedeTemperatura();
                       
        //     R7 canalr7 = new R7();
        //     meteorologia.Attach(canalr7);
        //     meteorologia.Dettach(canalbbc);
        //     Console.WriteLine("\n<----------------------\n");
        //     meteorologia.MedeTemperatura();
        // }


        

       
    } 
}

