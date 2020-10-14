using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Tutorial:Curs
    {

        public void RenameTutorial(int tutorialId, string tutorialName)
        {
            SetareCurs(tutorialId,tutorialName);
        }
    }
}
