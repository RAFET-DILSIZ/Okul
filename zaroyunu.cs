using System;

namespace Oyun
{
    class zaroyunu
    {
        public static void Main()
        {
            int a b c d e f;
            int op=20;
            int bp=20;
            int hedef;
            int top1;
            int top2;
            Random zar=new Random;
            if(op>20 && bp>20)
            {
                Console.WriteLine("3-18 arasında hedef girin");
            hedef = int.Parse(ConsoleReadLine());
            a = Next.zar(1,7);
            b = Next.zar(1,7);
            c = Next.zar(1,7);
            d= Next.zar(1,7);
            e = Next.zar(1,7);
            f = Next.zar(1,7);
            top1=a+b+c;
            top2=d+e+f;
            if((top1-hedef)>(top2-hedef))
            op--;
            else if((top2-hedef)>(top1-hedef))
            bp--;
            
            if(top1==11) 
            op++;
            if(top2==11)
            bp++;

            if(a==b && b==c)
            op+=2;

            if(d==e && e==f)
            bp+=2;

            if((a-b==1||b-a==1)&&(a-c==1||c-a)&&(b-c==1||c-b==1))
            op+=3;

            if((d-e==1||e-d==1)&&(d-f==1||f-d)&&(f-e==1||e-f==1))
            op+=3;

            }
            else
            {
                Console.WriteLine("oyuncunun puanı {0}\nBilgisayarın puanı{1}",op,bp);
                if(op>bp)
                Console.WriteLine("oyuncu kazandi");
                else if(bp>op)
                {
                    Console.WriteLine("bilgisayar kazandi");
                }
                else
                Console.WriteLine("Oyun beraber bitti");
            }
        } 
    }
    
}