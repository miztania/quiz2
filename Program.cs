namespace quiz2{
    class program{
       
        static void Main(string[] args){
            int countK1 = 0;
            int countK2 = 0;

            int N = int.Parse(Console.Read());
            int K = int.Parse(Console.Read());

            

            int[,] allPoint = getPoint(N,K);

            for (int i = 0;i<= N ;i++){
                

               checkIfPass(allPoint[i,1],allPoint[i,2],allPoint[i,3]);
               if(checkIfPass &&  (countK1 <= K || countK2 <= K)){
                if(allPoint[i,1] == 1){
                    countK1++;
                }else if(allPoint[i,2] == 2){
                    countK2++;
                }

                Console.WriteLine(i,allPoint[i,1]);
                }
               }
            }
            
        }   

        static int[,] getPoint(int N,int K){
           
            int[,] allPoint ;

             for(int i = 0 ; i <= N ; i++){
                int gender = int.Parse(Console.ReadLine());
                int point1 = int.Parse(Console.ReadLine());
                int point2 = int.Parse(Console.ReadLine()); 

                allPoint[i,1] = gender;
                allPoint[i,2] = point1;
                allPoint[i,3] = point2;

             }
             return allPoint;

        }

        static bool checkIfPass(int gen,int point1,int point2){
            if(point1 == 9 || point1 == 10 || point2 == 9 || point2 == 10 ){
                return true;
            }
        }
    }


