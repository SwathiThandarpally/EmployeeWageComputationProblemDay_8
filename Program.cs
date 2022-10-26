using EmployeewageAssignmentproblem;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to EmployeeWage Computation Program");    WELCOME MESSAGE

            //EmployeeCheck employeeCheck = new EmployeeCheck();
            //employeeCheck.Display();                                             USECASE-1

            //DailyWage dailyWage = new DailyWage();
            //dailyWage.Dispalay();                                                USECASE-2

            //AddPartTime addPartTime = new AddPartTime();
            //addPartTime.Display();                                               USECASE-3

            //SwitchCase switchCase = new SwitchCase();
            //switchCase.Display();                                                USECASE-4

            //WorkingDays workingDays = new WorkingDays();
            //workingDays.Display();                                               USECASE-5

            //ConditionHours conditionHours = new ConditionHours();
            //conditionHours.Display();                                            USECASE-6

            RefactorCode refactorCode = new RefactorCode();
            refactorCode.ComputeEmpWage();                                       USECASE-7


        }
    }
}
