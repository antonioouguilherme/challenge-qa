﻿using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace ChanlegeQA.Steps
{
    [Binding]
    public class CT021Steps : StepBase
    {
        [Given("que o usuário esteja na tela de autenticação")]
        public void DadoQueOUsuarioEstejaNaTelaDeAutenticacao()
        {
            //https://developer.grupoa.education/subscription/authentication/login
            driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/authentication/login");
        }

        [When("clicar em 'Recuperar senha'")]
        public void QuandoClicarEmRecuperarSenha()
        {
            // Simula o clique no botão de Recuperar senha
            driver.FindElement(By.LinkText("Recuperar senha")).Click();
        }

        [Then("receberá uma mensagem para verificar o email")]
        public void EntaoReceberaUmaMensagemParaVerificarOEmail()
        {
            // Localizar o elemento com a mensagem
            var alertElement = driver.FindElement(By.CssSelector(".text-sm.text-muted-foreground"));

            // Verificar se o texto está correto
            alertElement.Text.Should().Be("Verifique seu email!");

        }
    }
}       
    