﻿using Dooggy.CORE;
using System.Diagnostics;

namespace Dooggy.POC
{
    public class KatalonTeste : TestRobotScript
    {
        public void DATA()
        {
 
            Massa.Add(prmFlow: @"{ 'Nome': 'Alexandre', 'email': 'alexandre_bartie@hotmail.com' }");
            Massa.Add(prmFlow: @"{ 'Nome': 'Daniel', 'Sobrenome': 'Campinho', 'email': 'alexandre.bartie@gmail.com' }");
            Massa.Add(prmFlow: @"{ 'Nome': 'Luana', 'Sobrenome': 'Gonçalves', 'email': 'alexandre.bartie@gmail.com' }");
            Massa.Add(prmFlow: @"{ 'Nome': 'Lisia', 'Sobrenome': 'Amantos', 'sexo': 'Mulher', 'email': 'lisia.amantos@gmail.com' }");
            Massa.Add(prmFlow: @"{ 'Expectativa':'Salário + Desafio' }");
            Massa.Add(prmFlow: @"{ 'Expectativa':'Liderança + Ambiente + Equipe' }");

            Massa.Save();

        }
        public void SETUP()
        {

            Robot.GoURL(prmUrl: "https://katalon-test.s3.amazonaws.com/aut/html/form.html");

            Robot.Mapping("Nome", "id=first-name");
            Robot.Mapping("Sobrenome", "id=last-name");
            Robot.Mapping("Genero", "name=gender").SetDomain("Homem + Mulher + Indefinido");
            Robot.Mapping("Nascimento", "id=dob");
            Robot.Mapping("Endereco", "id=address");
            Robot.Mapping("Email", "id=email");
            Robot.Mapping("Senha", "id=password");
            Robot.Mapping("Empresa", "id=company");
            Robot.Mapping("Cargo", "id=role");
            Robot.Mapping("Expectativa", "id=expectation").SetDomain("Salário + Liderança + Ambiente + Equipe + Matriz + Desafio", "//*");
            Robot.Mapping("Aprendizado", "class=col-sm-10 development-ways").SetDomain("Livros + Cursos + Contribuições + Eventos + Blogs + Prática", "//*[@type='checkbox']") ;
            Robot.Mapping("Observacao", "id=comment");

        }
        public void PLAY()
        {

            Robot.Input("Nome", "Marcelo");
            Robot.Input("Sobrenome", "Silva");
            Robot.Input("Genero", "Mulher");
            Robot.Input("Nascimento", "06-05-1971");
            Robot.Input("Endereco", "Rua das Turmalinas, 68");
            Robot.Input("Email", "bartie.devops@outlook.com");
            Robot.Input("Senha", "123456");
            Robot.Input("Empresa", "Yduqs Faculdades Integradas");
            Robot.Input("Cargo", "Man");
            Robot.Input("Expectativa", "Ambiente + Desafio");
            Robot.Input("Aprendizado", "Livros + Eventos + Blogs");
            Robot.Input("Observacao", "Maravilhoso ...");

        }
        public void CHECK()
        {

            Robot.Submit();

        }
        public void CLEANUP()
        {

            Robot.Refresh();

        }

   }
}
