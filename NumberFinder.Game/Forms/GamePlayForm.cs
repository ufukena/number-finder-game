using NumberFinder.Game.Enums;
using NumberFinder.Game.Models;
using System.Windows.Forms;

namespace NumberFinder.Game.Forms
{
    public partial class GamePlayForm : Form
    {

        private GameSession gameSession;

        public GamePlayForm(GameType gameType)
        {
            InitializeComponent();

            gameSession = new GameSession();
            gameSession.gameType = gameType;

        }



    }
}
