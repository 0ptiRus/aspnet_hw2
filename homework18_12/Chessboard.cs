using System.Text;

namespace homework18_12
{
    public class Chessboard
    {
        private ILogger logger;
        
        public const int Width = 8;
        public const int Height = 8;

        public Chessboard(ILogger<Chessboard> logger)
        {
            this.logger = logger;
        }

        public void PrintBoard()
        {
            for(int i = 0; i < Height; i++)
            {
                StringBuilder builder = new();
                for(int j = 0; j < Width; j++)
                {
                    if(j % 2 == 0)
                    {
                        builder.Append('■');
                    }
                    else
                    {
                        builder.Append('□');
                    }
                }
                logger.Log(LogLevel.Information, builder.ToString());
            }
        }
    }
}
