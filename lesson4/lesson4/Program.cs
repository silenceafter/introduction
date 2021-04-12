using System;

namespace lesson4
{
    class Program
    {
        public enum Ships
        { // список кораблей
            Ничего = 0,
            ТорпедныйКатер = 1,
            Эсминец = 2,
            Крейсер = 3,
            Линкор = 4
        }
        
        static int[] MyShipsCnt = { 0, 4, 3, 2, 1 }; //кол-во кораблей и кол-во клеток на корабль, Катер = 4, Эсминец = 3, Крейсер = 2, Линкор = 1
        static char[,] MapArray = new char[10, 10]; // массив с клетками игрового поля
        static int stepCnt = 0; // шаг

        static void Main(string[] args)
        {
            string mycolumn = ""; // вывод игрового поля MapArray на экран
            for (int i = 0; i < MapArray.GetLength(0); i++)
            {
                for (int j = 0; j < MapArray.GetLength(1); j++)
                {
                    MapArray[i, j] = 'O';
                    mycolumn = mycolumn + MapArray[i, j] + ' ';
                }
                Console.WriteLine(mycolumn);
                Console.WriteLine("");
                mycolumn = "";
            }

            Random rnd = new Random();
            int coordinateX1, coordinateY1;
            int orient, total = 0;
           
            while (true)
            {
                total = GetMyShipsCnt();
                if (total == 0) { break; } 
                for (int i = 0; i < MyShipsCnt.GetLength(0); i++)
                {
                    if (MyShipsCnt[i] > 0)
                    {
                        coordinateX1 = rnd.Next(0, 9);
                        coordinateY1 = rnd.Next(0, 9);
                        orient = rnd.Next(0, 1);
                        // сгенерировали координаты, нужно узнать, можно ли их использовать, если нет - генерируем другие                        
                        ToGenerateMap(coordinateX1, coordinateY1, 0); //orient
                    }
                }              
            }            
        }

        static int GetMyShipsCnt()
        {
            int cnt = 0;
            for (int i = 0; i < MyShipsCnt.Length; i++) 
            {
                cnt += MyShipsCnt[i];
            }
            Console.WriteLine($"кораблей осталось разместить: {cnt}\n");
            return cnt;
        }

        static void GetMapArray()
        {
            string mycolumn = "";
            Console.WriteLine("");
            for (int i = 0; i < MapArray.GetLength(0); i++)
            {
                for (int j = 0; j < MapArray.GetLength(1); j++)
                {
                    mycolumn = mycolumn + MapArray[i, j] + ' ';
                }
                Console.WriteLine(mycolumn);
                mycolumn = "";
            }
            return;
        }

        static bool IsFieldsFree(int coordinateX, int coordinateY, int shipLong)
        {
            int cnt = 0;
            int i = 0, j = coordinateY;

            do
            {
                if (MapArray[coordinateX, j] == 'O')
                {
                    //Console.WriteLine($"координаты {coordinateX},{j}");
                    cnt++;
                }
                i++;
                j++;
            } while (i < shipLong);

            if (cnt == shipLong)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool IsNearCellFree(int coordinateX, int coordinateY1, int coordinateY2, int shipLong)
        {
            int cnt = 0;
            int i = 0, j = coordinateY1;
            int cntL = 0, cntR = 0, cntU = 0, cntD = 0;
            bool myfree = false;

            do
            {
                if (MapArray[coordinateX, j] == 'O')
                {
                    // 2 проверяем соседние клетки                                          
                    if (j == coordinateY1)
                    {
                        // первая клетка, проверяем слева, сверху, снизу                                                 
                        cntL = IsItFreeOnTheLeft(coordinateX, j);
                        cntU = IsItFreeFromAbove(coordinateX, j);
                        cntD = IsTheBottomFree(coordinateX, j);

                        if (cntL == 1 && cntU == 1 && cntD == 1)
                        {
                            // свободно
                            myfree = true;
                            Console.WriteLine($"первая клетка {coordinateX},{j}: свободно");
                        }
                        else
                        {
                            Console.WriteLine($"первая клетка {coordinateX},{j}: занято");
                            myfree = false;
                            break;
                        }
                    }
                    else if (j == coordinateY2)
                    {
                        // последняя клетка, проверяем справа, сверху, снизу
                        cntR = IsItFreeOnTheRight(coordinateX, j);
                        cntU = IsItFreeFromAbove(coordinateX, j);
                        cntD = IsTheBottomFree(coordinateX, j);

                        if (cntR == 1 && cntU == 1 && cntD == 1)
                        {
                            // свободно
                            myfree = true;
                            Console.WriteLine($"последняя клетка {coordinateX},{j}: свободно");
                        }
                        else
                        {
                            Console.WriteLine($"последняя клетка {coordinateX},{j}: занято");
                            myfree = false;
                            break;
                        }
                    }
                    else if (j != coordinateY1 && j != coordinateY2)
                    {
                        // средняя клетка, проверяем сверху и снизу
                        cntU = IsItFreeFromAbove(coordinateX, j);
                        cntD = IsTheBottomFree(coordinateX, j);

                        if (cntU == 1 && cntD == 1)
                        {
                            // свободно
                            myfree = true;
                            Console.WriteLine($"средняя клетка {coordinateX},{j}: свободно");
                        }
                        else
                        {
                            Console.WriteLine($"средняя клетка {coordinateX},{j}: занято");
                            myfree = false;
                            break;
                        }
                    }
                    cnt++;
                }
                i++;
                j++;
            } while (i < shipLong);
            return myfree;
        }

        static void ToPlaceAShip(int coordinateX, int coordinateY, int shipLong)
        {
            int cnt = 0;
            int i = 0, j = coordinateY;

            do
            {
                MapArray[coordinateX, j] = 'X';
                //Console.WriteLine($"координаты {coordinateX},{j}");
                cnt++;
                i++;
                j++;
            } while (i < shipLong);

            MyShipsCnt[shipLong]--;
            Console.WriteLine($"размещаем корабль: {(Ships)shipLong}, итератор: {shipLong}, элемент: {MyShipsCnt[shipLong]}");
            GetMapArray();
            return;
        }
        
        static int IsItFreeOnTheLeft(int coordinateX, int coordinateY)
        {
            // клетка слева           
            if (coordinateY > 0)
            {
                int coordinateYT = --coordinateY;
                if (MapArray[coordinateX, coordinateYT] == 'O')
                {
                    return 1;
                }
            }
            if (coordinateY == 0)
            {
                return 1;
            }
            return 0;
        }

        static int IsItFreeOnTheRight(int coordinateX, int coordinateY) 
        {
            // клетка справа
            if (coordinateY < 9)
            {
                int coordinateYT = ++coordinateY;
                if (MapArray[coordinateX, coordinateYT] == 'O')
                {
                    return 1;
                }
            }
            if (coordinateY == 9)
            {
                return 1;
            }
            return 0;
        }

        static int IsItFreeFromAbove(int coordinateX, int coordinateY)
        {
            // клетка сверху            
            if (coordinateX > 0)
            {
                int coordinateXT = --coordinateX;
                if (MapArray[coordinateXT, coordinateY] == 'O')
                {
                    return 1;
                }
            }
            if (coordinateX == 0)
            {
                return 1;
            }
            return 0;
        }

        static int IsTheBottomFree(int coordinateX, int coordinateY)
        {
            // клетка снизу
            if (coordinateX < 9)
            {
                int coordinateXT = ++coordinateX;
                if (MapArray[coordinateXT, coordinateY] == 'O')
                {
                    return 1;
                }
            }
            if (coordinateX == 9)
            {
                return 1;
            }
            return 0;
        }

        static void ToGenerateMap(int cX1, int cY1, int orient)
        {         
            int shipLong;
            int coordinateX1 = cX1, coordinateY1 = cY1;
            int coordinateX2, coordinateY2;

            stepCnt += 1;
            Console.WriteLine($"шаг: {stepCnt}");
            if (orient == 0)
            {
                // горизонтальное направление
                for (int i = 0; i < MyShipsCnt.GetLength(0); i++)
                {
                    if (MyShipsCnt[i] > 0)
                    {
                        Console.WriteLine($"проверяем координаты для: {(Ships)i}, итератор: {i}, элемент: {MyShipsCnt[i]}");
                        shipLong = i; // количество клеток, которые занимает корабль                       
                        coordinateX2 = coordinateX1;
                        coordinateY2 = coordinateY1 + (i - 1);                        
                        Console.WriteLine($"{coordinateX1},{coordinateY1};{coordinateX2},{coordinateY2}");

                        if (coordinateY2 < 10)
                        {
                            // координата вмещается                                                       
                            if (coordinateX1 > coordinateX2 || coordinateY1 > coordinateY2)
                            {
                                // первая координата располагается правее второй                            
                            }
                            else
                            {
                                // 1 первая координата располагается левее второй или на том же месте
                                //Console.WriteLine("Координата левее или равна");
                                bool fieldsFree = IsFieldsFree(coordinateX1, coordinateY1, i);                                                               
                                if (fieldsFree)
                                {
                                    // можем размещать корабль
                                    bool nearFree = IsNearCellFree(coordinateX1, coordinateY1, coordinateY2, i);
                                    if (nearFree) {
                                        // 3 можем размещать корабль                                
                                        ToPlaceAShip(coordinateX1, coordinateY1, i);
                                    } else
                                    {
                                        GetMapArray();
                                    }
                                    break;                                    
                                }
                                else
                                {
                                    // не можем размещать, нужны другие координаты
                                    Console.WriteLine("координаты заняты");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            // координата не вмещается
                            Console.WriteLine("координата не вмещается");
                            break;
                        }                        
                    }
                }
                return;
            }
            else
            {
                // вертикальное направление
            }
        }     
    }
}
    

