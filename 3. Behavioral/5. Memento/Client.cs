using System;

namespace Patterns._3._Behavioral._5._Memento
{
    public class Client
    {
        public static void Main()
        {
            var project = new Project();
            var github = new GithubRepo();
            
            // Сделали проект
            project.setVersion("Version 1.0");
            // Закинули в гитхаб
            github.SetSave(project.SaveProject());
            
            // Продолжили работу, но что-то пошло не так
            project.setVersion("Version 2.0");
            // Решаем откатить до версии 1.0
            project.LoadProject(github.GetSave());
            
            Console.WriteLine(project);
        }
    }
}