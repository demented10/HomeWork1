namespace HomeWork1
{
    public class Exercise11
    {
        private int[,] gameField = new int[3, 3];

        const char xSymbol = 'X';
        const char oSymbol = '0';
        const char emptySymbol = ' ';
        

        const int emptyField = 0;
        const int xField = 1;
        const int oField = 2;
        const int draft = 3;

        /// <summary>
        /// Метод устанавливает значение в ячейку игрового поля
        /// </summary>
        private bool SetField(int xPos, int yPos, int symbol)
        {
            if ((gameField[xPos, yPos] == emptyField) 
                && (xPos >= 0 && xPos < 3)
                && (yPos >= 0 && yPos < 3))
            {
                gameField[xPos, yPos] = symbol;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Метод определяет очередь и возвращает соответсвующий очереди символ
        /// </summary>
        private int GetCurrentCharId(int firstSymbol = xField)
        {
            int sum_oFields = 0, sum_xFields = 0;
            foreach(var i in gameField)
            {
                if (i == oField) sum_oFields++;
                else if (i == xField) sum_xFields++;
            }
            if(sum_oFields == 0 && sum_xFields == 0) return firstSymbol;

            return sum_xFields > sum_oFields ? oField : xField;

        }
       
        
        #region CheckWinner
        private int CheckColumnWinner(int columnNumber)
        { 
            var startValue = gameField[columnNumber, 0];
            if(startValue == emptyField) return emptyField;
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                if (gameField[columnNumber, i] != startValue) return emptyField;
            }
            return startValue;
           
        }
        private int CheckRowWinner(int rowNumber)
        {
            var startValue = gameField[0, rowNumber];
            if (startValue == emptyField) return emptyField;
            for (int i = 0; i < gameField.GetLength(1); i++)
            {
                if (gameField[i, rowNumber] != startValue) return emptyField;
            }
            return startValue;
            
        }
        private int CheckDiagonalWinner()
        {
            //center
            var startValue = gameField[gameField.GetLength(0) / 2, gameField.GetLength(1) / 2];
            var match = true;
            if (startValue == emptyField) return emptyField;
            for (int i = 0; i < gameField.GetLength(1); i++)
            {
                if (gameField[i, i] != startValue) match = false;
            }
            if(match) return startValue;
            for (int i = 0; i < gameField.GetLength(1); i++)
            {
                if (gameField[i, gameField.GetLength(1) - 1 - i] != startValue) return emptyField;
            }
            return startValue;
        }
        private bool CheckDraft()
        {
            //Get zero count LINQ
            var count = gameField.Cast<int>().Count(i => i == emptyField);
            return count == 0;
        }

        private int winner;


        private int CheckWinner()
        {
            winner = emptyField;
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                winner = CheckColumnWinner(i);
                if (winner != emptyField)
                {
                    return winner;                    
                }
            }
            for (int i = 0; i < gameField.GetLength(1); i++)
            {
                winner = CheckRowWinner(i);
                if (winner != emptyField)
                {                   
                    return winner;
                }
            }

            winner = CheckDiagonalWinner();
            if (winner != emptyField)
            {               
                return winner;
            }
            if (CheckDraft())
            {
                winner = draft;
                return draft;
            }
            
            return emptyField;
            
        }



        #endregion
        #region Drawing
        /// <summary>
        /// Метод возвращает символ в ячейке игрового поля
        /// </summary>
        private char GetSymbolByPosition(int xPos, int yPos)
        {
            int value = gameField[xPos, yPos];
            if (value == xField) return xSymbol;
            else if (value == oField) return oSymbol;
            else return ' ';
        }
        /// <summary>
        /// Отрисовка игрового поля
        /// </summary>
        private void DrawField()
        {
            string fieldGraphics =
                
                $" {GetSymbolByPosition(0, 2)} | {GetSymbolByPosition(1, 2)} | {GetSymbolByPosition(2, 2)} \n" +
                $"---+---+---\n" +
                $" {GetSymbolByPosition(0, 1)} | {GetSymbolByPosition(1, 1)} | {GetSymbolByPosition(2, 1)} \n" +
                $"---+---+---\n" +
                $" {GetSymbolByPosition(0, 0)} | {GetSymbolByPosition(1, 0)} | {GetSymbolByPosition(2, 0)} \n";
            Console.WriteLine(fieldGraphics);
        }
        /// <summary>
        /// Обработка ввода с клавиатуры
        /// </summary>
        private void GetInput()
        {
            
                _ = int.TryParse(Console.ReadLine(), out int value);

                if (value > 0 && value <= 9)
                {
                    int xPos = (value - 1) % 3;
                    int yPos = (value - 1) / 3;
                    SetField(xPos, yPos, GetCurrentCharId());
                }
            
        }

        private void DisplayWinner()
        {
            switch (winner)
            {
                case xField:
                    Console.WriteLine("Победил X");
                    break;
                case oField:
                    Console.WriteLine("Победил O");
                    break;
                case draft:
                    Console.WriteLine("Ничья");
                    break;
            }
        }

        #endregion

        #region Main Functions
        public void Start()
        {
            var run = true;
            DrawField();
            do
            {
               run = Update();
            } 
            while (run);
            DisplayWinner();
        }

        private bool Update()
        {
            
            GetInput();
            Console.Clear();
            DrawField();
            var winner = CheckWinner();
            return winner == emptyField;

        }
        #endregion
    }
}
