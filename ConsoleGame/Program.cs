<<<<<<< HEAD:ConsoleGame/Program.cs
    using System;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 4787d9905d2b1c20e8667f19a8c39068178915a3:Program.cs

namespace ConsoleGame
{
    class Program
    {
        private const int ScreenWindth = 100;
<<<<<<< HEAD:ConsoleGame/Program.cs
        private const int ScreenHeight=20;
=======
        private const int ScreenHeight=53;
>>>>>>> 4787d9905d2b1c20e8667f19a8c39068178915a3:Program.cs
        private static readonly char[] Screen=new char[ScreenWindth*ScreenHeight];
        private const int MapWindth=32;
        private const int MapHeight=32;

private static double DEPTH=16;
        private static double _PlayerX=5;
        private static double _PlayerY=9;
        private static double _PlayerA=0;
        private static StringBuilder Map=new StringBuilder();
        private static double FOV=Math.PI /3; 
        static void Main(string[] args)
        {
            Console.Title="my first console game";
            Console.SetWindowSize(ScreenWindth, ScreenHeight);
            Console.SetBufferSize(ScreenWindth, ScreenHeight);
            Console.CursorVisible=false;
            Map.Append("################################");
            Map.Append("#................#.............#");
            Map.Append("#................#.............#");
            Map.Append("#................#.............#");
            Map.Append("#......#....#....#.............#");
            Map.Append("#........#.....................#");
            Map.Append("#..............................#");
            Map.Append("##########.....................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#........#...........#.........#");
            Map.Append("#..........#........#..........#");
            Map.Append("#............#.....#...........#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("#..............................#");
            Map.Append("################################");
       
            var dateTimeFrom=DateTime.Now;
            while (true)
            {
                var dateTimeTo=DateTime.Now;
              double  elapsedTime=(dateTimeTo-dateTimeFrom).TotalSeconds;//разница с момента запуска до текущего момента 
              dateTimeFrom=DateTime.Now;//
                // _PlayerA+=elipsedTime* 0.3; //угол поворота при разных условиях отличается,поэтому его нужно умножать на фиксированный отрезок,это время (в секундах)
                //Прошедшее с запуска до текущего момента
                if (Console.KeyAvailable)//проверка ли нажата какая-либо кнопка
                {
                    ConsoleKey consolekey =Console.ReadKey(true).Key;//обект класс для определения какая кнопка нажата
                    //конструкция для выбора действия при определённой нажатой кнопке
                    switch (consolekey) 
                    
                    {
                        case ConsoleKey.A:
                        _PlayerA+=elapsedTime*10d;
                        break;
                        case ConsoleKey.D:
                        _PlayerA-=elapsedTime*10d;
<<<<<<< HEAD:ConsoleGame/Program.cs
                        break;
                        case ConsoleKey.S:
                        _PlayerY+=Math.Sin(_PlayerA)*10d*elapsedTime;
                        _PlayerX+=Math.Cos(_PlayerA)*10d*elapsedTime;
                        break;
                        case ConsoleKey.W:
                        _PlayerY-=Math.Sin(_PlayerA)*10d*elapsedTime;
                        _PlayerX-=Math.Cos(_PlayerA)*10d*elapsedTime;
=======
                        break;
                        case ConsoleKey.W:
                        _PlayerX+=Math.Sin(_PlayerA)*10d*elapsedTime;
                        _PlayerY+=Math.Cos(_PlayerA)*10d*elapsedTime;
                        if (Map[(int)_PlayerY*MapWindth+(int)_PlayerX]=='#')
                        {
                        _PlayerX-=Math.Sin(_PlayerA)*10d*elapsedTime;
                        _PlayerY-=Math.Cos(_PlayerA)*10d*elapsedTime;
                        }
                        
                        break;
                        case ConsoleKey.S:
                        _PlayerX-=Math.Sin(_PlayerA)*10d*elapsedTime;
                        _PlayerY-=Math.Cos(_PlayerA)*10d*elapsedTime;
                         if (Map[(int)_PlayerY*MapWindth+(int)_PlayerX]=='#')
                        {
                            _PlayerX+=Math.Sin(_PlayerA)*10d*elapsedTime;
                        _PlayerY+=Math.Cos(_PlayerA)*10d*elapsedTime;
                        }
>>>>>>> 4787d9905d2b1c20e8667f19a8c39068178915a3:Program.cs
                        break;
                        default:
                        break;
                    }
                }
                
                // цилк для прохода по ширине
                for (int x = 0; x < ScreenWindth; x++) 
                {
                    double rayAngle=_PlayerA+FOV/2-x*FOV/ScreenWindth; //Узнать угол луча для первого по ширине пикселя: угол обзора игрока + половина обзора - индекс_линии_по_ширине * угол обзора / ширину экрана
                    double rayX=Math.Sin(rayAngle); //координаты луча равные синусу угла обзора
                    double rayY=Math.Cos(rayAngle);//координаты луча равные синусу угла обзора
                    double distanseToWall=0;//дистанция до припятствия
                    bool wallHit=false;//булева переменная для определения столкновения луча с припятствием
                    bool IsBound=false;
                while (!wallHit && distanseToWall <=DEPTH)//Цикл для проверки координаты блока с которым столкнулся луч
                {
                    distanseToWall+=0.1;//Увеличение дистанции до объекта
                    int testX=(int)(_PlayerX+rayX*distanseToWall);//Координата объкта по х
                    int testY=(int)(_PlayerY+rayY*distanseToWall);//Координата объкта по y
                    if (testX<0 || testX>=DEPTH + _PlayerX || testY<0 || testY>=DEPTH + _PlayerY)//Усливие для определения границ видимости -это границы карты и глубина
                    //Если координаты объекта меньше нуля или больше или равны глубине и координатам игрока
                    //Если истина,то перед нами что-то
                    {
                        wallHit=true;
                        distanseToWall=DEPTH;
                    }
                    else //Иначе помечаем,что переднами стена
                    {
                        char testCell=Map[testY * MapWindth +testX];
                        if (testCell=='#')
                        {
                            wallHit=true;
                            var bounddsVectorList=new List<(double module, double cos)>(); //Вектор для определения граней
                            for (int tx = 0; tx < 2; tx++)
                            {
                                for (int ty = 0; ty < 2; ty++)
                                {
                                    double vx=testX+tx-_PlayerX;//Вектор по вертикали
                                    double vy=testY+tx-_PlayerY;//Вектор по-горизонтали
                                    double VectorModul=Math.Sqrt(vx*vx+vy*vy);//Модуль векторов
                                    double cosAngle=rayX*vx/VectorModul+rayY*vy/VectorModul;//Угол между векторами
                                    bounddsVectorList.Add((VectorModul,cosAngle));//Создание вектора
                                }
                            }
                            bounddsVectorList=bounddsVectorList.OrderBy(v=>v.module).ToList();//Сортировка
                                double boundAngle=0.03 / distanseToWall;//Константа через котору проверяется достиг ли вектор угла или это не видимая часть
                                if (Math.Acos(bounddsVectorList[0].cos)<boundAngle || Math.Acos(bounddsVectorList[1].cos)<boundAngle)//Если углы вектора меньше константы ,то мы попали в ребро
                                {
                                     IsBound=true;
                                }
                        }
                    }                                       
                }
                int celling =(int)(ScreenHeight/2d -ScreenHeight*FOV/distanseToWall) ;//определяем ,что это небо по формуле h/2(1-1/d)
                int floor=ScreenHeight-celling;//Пол-это небо отнятое от высоты
                char  wallShade =' '; //переменная для тени стен
                if (IsBound)//Если это ребро,то рисуем на нём "|"
                {
                    wallShade='|';
                }
                else if (distanseToWall<=DEPTH/4d)//Если Дистанция до стены меньше глубины обзора /4 ,то это ближняя стена
                {
                 wallShade='\u2588';   
                }
                else if (distanseToWall<=DEPTH/3d)
                {
                 wallShade='\u2593';   
                }
                else if (distanseToWall<=DEPTH/2d)
                {
                 wallShade='\u2590';   
                }
                else if (distanseToWall<=DEPTH)
                {
                 wallShade='\u2591';   
                }
                else
                {
                    
                }
                char floorColor='\u2580';
                for (int y = 0; y < ScreenHeight; y++)//проходим для по высоте по всему массиву
                    {
                        if (y <=celling) //Условие для определения неба
                        {
                            Screen[y*ScreenWindth+x]=' ';
                        }
                        else if(y>celling && y<=floor)//Условие для стен,они ниже неба,но больше пола
                        {
                            Screen[y*ScreenWindth+x]=wallShade;//Устанавливает символ стены
                        }
                        else //всё остальное пол
                        {
                            char floorShade;
                            double b = 1 -(y-ScreenHeight/2d)/(ScreenHeight/2d);
                            if (b<0.25)
                            {
                                floorShade='#';
                            }
                            else if (b<0.5)
                            {
                                floorShade='x';
                            }
                            else if (b<0.75)
                            {
                                floorShade='-';
                            }
                            else if (b<0.9)
                            {
                                floorShade='.';
                            }
                            else
                            {
                                floorShade=' ';
                            }
                            Screen[y*ScreenWindth+x]=floorShade;
                        }
                    }
                }
                //статистика положения,угла обзора и кадров в секунду
                char[] stats=$"X:{(float)(_PlayerX)}, Y:{(float)_PlayerY}, Angle: {(float)_PlayerA}, FPS: {(int)(1/elapsedTime)}".ToCharArray();
                stats.CopyTo(Screen,0);
                //карта
                for (int x = 0; x < MapWindth; x++)
                {
                    for (int y = 0; y < MapHeight; y++)
                    {
                        Screen[(y+1)*ScreenWindth+x]=Map[y*MapWindth+x];

                    }
                }
                //координаты игрока
                Screen[(int)(_PlayerY+1)*ScreenWindth+(int)_PlayerX]='P';
                
                
    Console.CursorVisible=false;
            Console.SetCursorPosition(0,0);
            Console.Write(Screen);
        }
           
        }
    }
}
