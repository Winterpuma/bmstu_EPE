using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace COCOMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double relyVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.15;
                case 2:
                    return 1.4;
                case -1:
                    return 0.86;
                case -2:
                    return 0.75;
            }
            return 0;
        }

        private double dataVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.08;
                case 2:
                    return 1.16;
                case -1:
                    return 0.94;
            }
            return 0;
        }

        private double cplxVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.15;
                case 2:
                    return 1.3;
                case -1:
                    return 0.85;
                case -2:
                    return 0.7;
            }
            return 0;
        }


        private double timeVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.11;
                case 2:
                    return 1.5;
            }
            return 0;
        }

        private double storVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.06;
                case 2:
                    return 1.21;
            }
            return 0;
        }

        private double virtVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.15;
                case 2:
                    return 1.3;
                case -1:
                    return 0.87;
            }
            return 0;
        }

        private double turnVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.07;
                case 2:
                    return 1.15;
                case -1:
                    return 0.87;
            }
            return 0;
        }


        private double acapVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 0.86;
                case 2:
                    return 0.71;
                case -1:
                    return 1.19;
                case -2:
                    return 1.46;
            }
            return 0;
        }

        private double aexpVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 0.91;
                case 2:
                    return 0.82;
                case -1:
                    return 1.15;
                case -2:
                    return 1.29;
            }
            return 0;
        }


        private double pcapVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 0.86;
                case 2:
                    return .7;
                case -1:
                    return 1.17;
                case -2:
                    return 1.42;
            }
            return 0;
        }

        private double vexpVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return .9;
                case -1:
                    return 1.1;
                case -2:
                    return 1.21;
            }
            return 0;
        }


        private double lexpVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return .95;
                case -1:
                    return 1.07;
                case -2:
                    return 1.14;
            }
            return 0;
        }

        private double modpVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return .91;
                case 2:
                    return .82;
                case -1:
                    return 1.1;
                case -2:
                    return 1.24;
            }
            return 0;
        }

        private double toolVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return .91;
                case 2:
                    return .82;
                case -1:
                    return 1.1;
                case -2:
                    return 1.24;
            }
            return 0;
        }

        private double scedVal(int level)
        {
            switch (level)
            {
                case 0:
                    return 1;
                case 1:
                    return 1.04;
                case 2:
                    return 1.1;
                case -1:
                    return 1.08;
                case -2:
                    return 1.23;
            }
            return 0;
        }


        double c1, c2, p1, p2;

        void SetConst(int kloc)
        {
            if (kloc < 50)
            {
                c1 = 3.2;
                p1 = 1.05;
                c2 = 2.5;
                p2 = 0.38;
            }
            else
            if (kloc < 500)
            {
                c1 = 3;
                p1 = 1.12;
                c2 = 2.5;
                p2 = 0.35;
            }
            else
            {
                c1 = 2.8;
                p1 = 1.2;
                c2 = 2.5;
                p2 = 0.32;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var kloc = Int32.Parse(KLOC.Text);
            var rely = relyVal(Int32.Parse(RELY.Text));
            var data = dataVal(Int32.Parse(DATA.Text));
            var cplx = cplxVal(Int32.Parse(CPLX.Text));
            var time = timeVal(Int32.Parse(TIME.Text));
            var stor = storVal(Int32.Parse(STOR.Text));
            var virt = virtVal(Int32.Parse(VIRT.Text));
            var turn = turnVal(Int32.Parse(TURN.Text));
            var acap = acapVal(Int32.Parse(ACAP.Text));
            var aexp = aexpVal(Int32.Parse(AEXP.Text));
            var pcap = pcapVal(Int32.Parse(PCAP.Text));
            var vexp = vexpVal(Int32.Parse(VEXP.Text));
            var lexp = lexpVal(Int32.Parse(LEXP.Text));
            var modp = modpVal(Int32.Parse(MODP.Text));
            var tool = toolVal(Int32.Parse(TOOL.Text));
            var sced = scedVal(Int32.Parse(SCED.Text));

            SetConst(kloc);

            var eaf = rely * data * cplx * time * stor * virt * turn * acap * aexp * pcap * vexp * lexp * modp * tool * sced;


            var work = c1 * eaf * Math.Pow(kloc, p1);
                time = c2 * Math.Pow(work, p2);

            var overWork = work * .08;
            var overTime = time * .36;
            var overPeople = Math.Ceiling(overWork / overTime);

            var projWork = work * .18;
            var projTime = time * .36;
            var proPeople = Math.Ceiling(projWork / projTime);

            var detProjWork = work * .25;
            var detProjTime = time * .18;
            var detProPeople = Math.Ceiling(detProjWork / detProjTime);


            var codeWork = work * .25;
            var codeTime = time * .18;
            var codePeople = Math.Ceiling(codeWork / codeTime);


            var testWork = work * .31;
            var testTime = time * .28;
            var testPeople = Math.Ceiling(testWork / testTime);



            var anWork = work * .4;
            var prWork = work * .12;
            var pgWork = work * .44;
            var teWork = work * .6;
            var veWork = work * .14;
            var caWork = work * .7;
            var qaWork = work * .7;
            var maWork = work * .6;

            allWork.Text = (work + overWork).ToString("n2");
            allTime.Text = (time + overTime).ToString("n2");


            planWork.Text = projWork.ToString("n2");
            planTime.Text = time.ToString("n2");

            detWork.Text = detProjWork.ToString("n2");
            detTime.Text = detProjTime.ToString("n2");

            codingWork.Text = codeWork.ToString("n2");
            codingTime.Text = codeTime.ToString("n2");

            intWork.Text = testWork.ToString("n2");
            intTime.Text = testTime.ToString("n2");

            this.overWork.Text = overWork.ToString("n2");
            this.overTime.Text = overTime.ToString("n2");

            AnaticsWork.Text = anWork.ToString("n2");
            projectWork.Text = prWork.ToString("n2");
            programmingWork.Text = pgWork.ToString("n2");
            this.testWork.Text = teWork.ToString("n2");
            verificationWork.Text = veWork.ToString("n2");
            kazlerWork.Text = caWork.ToString("n2");
            QAWork.Text = qaWork.ToString("n2");
            manWork.Text = maWork.ToString("n2");


            var workersData = new ColumnSeries
            {
                Title="Проект 1",
                Values = new ChartValues<double> { overPeople, proPeople, detProPeople, codePeople, testPeople }
            };

            var workersSeries = new SeriesCollection
            {
                workersData
            };

            Workres.Series = workersSeries;
        }
    }
}
