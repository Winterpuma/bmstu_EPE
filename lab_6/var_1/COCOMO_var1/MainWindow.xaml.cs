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

using COCOMO.Attributes;

namespace COCOMO_var1
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

        public double c1, c2, p1, p2;

        /// <summary>
        /// Режимы модели
        /// </summary>
        void SetConst(int kloc)
        {
            // Обычный
            if (kloc < 50)
            {
                c1 = 3.2;
                p1 = 1.05;
                c2 = 2.5;
                p2 = 0.38;
            }
            // Промежуточный
            else if (kloc <= 500)
            {
                c1 = 3;
                p1 = 1.12;
                c2 = 2.5;
                p2 = 0.35;
            }
            // Встроенный
            else
            {
                c1 = 2.8;
                p1 = 1.2;
                c2 = 2.5;
                p2 = 0.32;
            }
        }

        /// <summary>
        /// Результат учета 15 уточняющих факторов
        /// </summary>
        /// <returns>EAF</returns>
        private double CountEAF()
		{
            var kloc = Int32.Parse(KLOC.Text);

            var rely = Product.RELY(Int32.Parse(RELY.Text));
            var data = Product.DATA(Int32.Parse(DATA.Text));
            var cplx = Product.CPLX(Int32.Parse(CPLX.Text));

            var time = Hardware.TIME(Int32.Parse(TIME.Text));
            var stor = Hardware.STOR(Int32.Parse(STOR.Text));
            var virt = Hardware.VIRT(Int32.Parse(VIRT.Text));
            var turn = Hardware.TURN(Int32.Parse(TURN.Text));

            var acap = Personnel.ACAP(Int32.Parse(ACAP.Text));
            var aexp = Personnel.AEXP(Int32.Parse(AEXP.Text));
            var pcap = Personnel.PCAP(Int32.Parse(PCAP.Text));
            var vexp = Personnel.VEXP(Int32.Parse(VEXP.Text));
            var lexp = Personnel.LEXP(Int32.Parse(LEXP.Text));

            var modp = Project.MODP(Int32.Parse(MODP.Text));
            var tool = Project.TOOL(Int32.Parse(TOOL.Text));
            var sced = Project.SCED(Int32.Parse(SCED.Text));

            SetConst(kloc);

            return rely * data * cplx * time * stor * virt * turn * acap * aexp * pcap * vexp * lexp * modp * tool * sced;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var kloc = Int32.Parse(KLOC.Text);

            var eaf = CountEAF();

            var work = c1 * eaf * Math.Pow(kloc, p1);
            var time = c2 * Math.Pow(work, p2);

            // Планирование и определение требований 
            var overWork = work * .08;
            var overTime = time * .36;
            var overPeople = Math.Ceiling(overWork / overTime);

            // Проектирование продукта 
            var projWork = work * .18;
            var projTime = time * .36;
            var proPeople = Math.Ceiling(projWork / projTime);

            // Детальное проектирование 
            var detProjWork = work * .25;
            var detProjTime = time * .18;
            var detProPeople = Math.Ceiling(detProjWork / detProjTime);

            // Кодирование и тестирование отдельных модулей
            var codeWork = work * .25;
            var codeTime = time * .18;
            var codePeople = Math.Ceiling(codeWork / codeTime);

            // Интеграция и тестирование
            var testWork = work * .31;
            var testTime = time * .28;
            var testPeople = Math.Ceiling(testWork / testTime);


            
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

            // Декомпозиция работ по созданию ПО
            var decompose = new Decompose(work);

            AnaticsWork.Text = decompose.AnalysisWork.ToString("n2");
            projectWork.Text = decompose.ProjectingWork.ToString("n2");
            programmingWork.Text = decompose.ProgrammingWork.ToString("n2");
            this.testWork.Text = decompose.TestingWork.ToString("n2");
            verificationWork.Text = decompose.VerificationWork.ToString("n2");
            kazlerWork.Text = decompose.ChancelleryWork.ToString("n2");
            QAWork.Text = decompose.QaWork.ToString("n2");
            manWork.Text = decompose.ManualWork.ToString("n2");


            var workersData = new ColumnSeries
            {
                Title = "Проект 1",
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
