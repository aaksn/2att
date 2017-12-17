using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassL
{    
    public enum GameState
    {
        BEFORE_START,  // игра не начиналась
        PLAYING,       // игра идет        
        FAIL           // игра закончилась поражением
    }
    public enum BallColor // Цвет шара в клетке
    {        
        Red,
        Blue,
        DarkBlue,
        Orange,
        Brown,
        Green,
        Pink
    }    
    public enum NewBallColor // Цвет шара в клетке перед появлением
    {
        Red,
        Blue,
        DarkBlue,
        Orange,
        Brown,
        Green,
        Pink
    }
    public enum CellState
    {
        BALL,        // клетка заполнена
        NEWBALL,    // клетка будет заполнена
        NOBALL          // клетка пуста
    }
    public struct GameCell
    {
        public CellState state;  // состояние клетки
        public BallColor color;  // цвет шара
        public NewBallColor newcolor;  // цвет шара
        public bool choose;     // выбрана ли клетка

        public GameCell(CellState state, BallColor color, NewBallColor newcolor, bool choose)
        {
            this.state = state;
            this.color = color;
            this.newcolor = newcolor;
            this.choose = choose;
        }
    }
    public class Game
    {
        public Game() { }

        // объект Random для генерации случайных чисел        
        private Random rnd = new Random();
        // состояние игры
        private GameState state = GameState.BEFORE_START;
        // двумерный массив для хранения игрового поля
        // (создается / пересоздается при старте игры)
        private GameCell[,] field = null;
        // глобальная константа заадающая количество шагов на шаге игры
        private int ballCount = 0;
        // количество шаров на поле
        private int ballsonfield = 0;
        //количество набранных очков
        private int score = 0;
        //количество выбранных ячеек
        private int choosecount = 0;

        public void NewGame(int n) // Создание новой игры
        {
            state = GameState.PLAYING;
            field = new GameCell[n, n];
            ballCount = 0;
            choosecount = 0;
            ballsonfield = 0;
            score = 0;
            Debug.WriteLine(Ballsonfield.ToString()+"/"+ballsonfield.ToString());
            ballCount = n/3;            
            for (int i = 0; i < n; i++) // Создаём пустое поле
            {
                for (int j = 0; j < n; j++)
                {
                    field[i, j].state = CellState.NOBALL;
                }
            }
            int balls = 0;
            for (int i = 0; i < ballCount; i++) // Первоначальное заполнение шарами
            {
                while (balls < ballCount)
                {
                    int x = rnd.Next(n),
                        y = rnd.Next(n);
                    if (field[x, y].state == CellState.NOBALL)
                    {
                        field[x, y].state = CellState.BALL;                        
                        field[x, y].color = (BallColor)rnd.Next(Enum.GetNames(typeof(BallColor)).Length);
                        balls++;
                        ballsonfield++;
                    }
                }                
            }
            NewBallsAdd(ballCount);
        }
        private void BallsDelete(int y, int x) // Удаление одинаковых шаров, параметры - место на которое был перемещён шар
        {
            bool vertical = true;
            int ballsright = 0,
                ballsleft = 0,
                ballsup = 0,
                ballsdown = 0;
            int xstart = x,
                xend = x,
                ystart = y,
                yend = y;
            for (int i = x; i < FieldCount - 1; i++) // Поиск по горизонтали вправо (включая х)
            {
                if (field[y, i + 1].state == CellState.BALL && field[y, i + 1].color == field[y, i].color
                    && field[y, i + 1].color == field[y, x].color && field[y, i].color == field[y, x].color
                    && field[y, i].state == CellState.BALL)
                {
                    ballsright++;
                    xend++;
                }
            }
            for (int i = x; i >= 1; i--) // Поиск по горизонтали влево
            {
                if (field[y, i - 1].state == CellState.BALL && field[y, i - 1].color == field[y, i].color
                    && field[y, i - 1].color == field[y, x].color && field[y, i].color == field[y, x].color
                    && field[y, i].state == CellState.BALL)
                {
                    ballsleft++;
                    xstart--;
                }
            }
            if (ballsright + ballsleft > ballCount) // Условие удаления по горизонтали
            {                
                for (int i = xstart; i <= xend; i++)
                {
                    field[y, i].state = CellState.NOBALL;
                    score++;
                    ballsonfield--;
                }                
            }            

            if (vertical) // Поиск по вертикали
            {
                for (int i = y; i >= 1; i--) // Поиск по вертикали вверх (включая у)
                {
                    if (field[i, x].state == CellState.BALL && field[i - 1, x].state == CellState.BALL
                        && field[i - 1, x].color == field[i, x].color
                        && field[i, x].color == field[y, x].color && field[i - 1, x].color == field[y, x].color)
                    {
                        
                        ballsup++;
                        ystart--;                        
                    }
                }               

                for (int i = y; i < FieldCount - 1; i++) // Поиск по вертикали вниз
                {
                    if (field[i, x].state == CellState.BALL && field[i + 1, x].state == CellState.BALL 
                        && field[i + 1, x].color == field[i, x].color
                        && field[i, x].color == field[y, x].color && field[i + 1, x].color == field[y, x].color)
                    {
                        ballsdown++;
                        yend++;                        
                    }
                }                
                if (ballsup + ballsdown > ballCount) // Условие удаления по вертикали
                {                    
                    for (int i = ystart; i <= yend; i++)
                    {
                        field[i, x].state = CellState.NOBALL;
                        score++;
                        ballsonfield--;
                    }                    
                }
            }
        }
        
        private bool CheckMove(int x, int y) // Проверка возможности перемещения шара, параметры - новое место
        {            
            return field[x, y].state != CellState.BALL; // test realisation
        }
        private void Move(int x, int y) // Преремещение шара, параметры - новое место
        {            
            if (CheckMove(x,y))
            {
                bool nb = false;
                for (int i = 0; i < FieldCount; i++) // ищем откуда перемещать
                {
                    for (int j = 0; j < FieldCount; j++)
                    {
                        if (field[i, j].choose)
                        {
                            field[x, y].state = CellState.BALL;
                            field[x, y].color = field[i, j].color;
                            field[i, j].state = CellState.NOBALL;
                            field[i, j].choose = false;
                            choosecount--;
                            nb = true;
                            break;
                        }
                    }
                    if (nb)
                    {
                        break;
                    }
                }
            }            
        }
        private void NewBallsAdd(int n)
        {
            int balls = 0;
            for (int i = 0; i < n; i++)
            {
                while (balls < n)
                {
                    int x = rnd.Next(FieldCount),
                        y = rnd.Next(FieldCount);
                    if (field[x, y].state == CellState.NOBALL)
                    {
                        field[x, y].state = CellState.NEWBALL;
                        field[x, y].newcolor = (NewBallColor)rnd.Next(Enum.GetNames(typeof(BallColor)).Length);
                        balls++;
                        BallsDelete(x, y);
                    }
                }
            }
        }
        private void BallsAdd(int n) // Добавление шаров на местах появления
        {
            int balls = 0;
            for (int k = 0; k < FieldCount; k++)
            {
                for (int j = 0; j < FieldCount; j++)
                {
                    if (field[k, j].state == CellState.NEWBALL)
                    {
                        field[k, j].state = CellState.BALL;
                        field[k, j].color = (BallColor)field[k, j].newcolor;
                        balls++;                        
                    }                    
                }
            }
            if (balls == n - 1) // Если шар был перемещён на место появление нового
            {                
                do
                {
                    int x = rnd.Next(FieldCount),
                        y = rnd.Next(FieldCount);
                    if (field[x, y].state == CellState.NOBALL)
                    {
                        field[x, y].state = CellState.BALL;
                        field[x, y].color = (BallColor)rnd.Next(Enum.GetNames(typeof(BallColor)).Length);
                        balls++;
                    }
                } while (balls < n);
            }
            ballsonfield += n;            
        }
        private void CalcGameState() // Проверка статуса игры
        {
            if (state == GameState.BEFORE_START)
                return;
            else if (ballsonfield==FieldCount*FieldCount)
            {
                state = GameState.FAIL;                
            }            
        }
        public void LeftMouseClick(int row, int col) // Обработка клика
        {
            if (state != GameState.PLAYING)      // если игра завершена
                return;
            else if (field[row, col].state == CellState.BALL && choosecount == 0) // Выбор клетки с шаром
            {
                field[row, col].choose = true;
                choosecount++;                
            }
            else if (field[row, col].state != CellState.BALL && choosecount == 1) // Перемещения шара
            {                
                Move(row, col);
                BallsDelete(row, col);                
                BallsAdd(ballCount);
                if (FieldCount * FieldCount - ballsonfield >= ballCount)
                {                    
                    NewBallsAdd(ballCount);
                } else state = GameState.FAIL;
            }
            else if (field[row, col].state == CellState.BALL && field[row, col].choose == true &&
                choosecount == 1) //если в клетке шар и она выбрана - снятие выбора
            {
                field[row, col].choose = false;
                choosecount--;
               
            }
            else if (field[row, col].choose == false && choosecount == 1 && field[row, col].state == CellState.BALL) // если уже был выбран другой шар
            {
                bool nb = false;
                for (int i = 0; i < FieldCount; i++)
                {
                    for (int j = 0; j < FieldCount; j++)
                    {
                        if (field[i, j].choose == true)
                        {
                            field[i, j].choose = false;
                            field[row, col].choose = true;
                            nb = true;
                            break;
                        }
                    }
                    if (nb)
                    {
                        break;
                    }
                }                
            }            
            CalcGameState();
        }
        public int FieldCount
        {
            get
            {
                return field == null ? 0 : field.GetLength(0);
            }
        }
        public int Ballsonfield
        {
            get
            {
                return ballsonfield;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
        }
        public GameState State
        {
            get
            {
                return state;
            }
        }
        public GameCell this[int row, int col]
        {
            get
            {
                return field[row, col];
            }
        }
    }
}
