using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT016Step : StepBase
{
    [Given("que o usuário preencha o campo Telefone com menos de 10 caracteres")]
    public void DadoQueOUsuarioPreenchaOCampoTelefoneComMenosDeDezCaracteres()
    {
        //Tela do cadastro https://developer.grupoa.education/subscription/personal-data
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data");

        // Clicar no campo telefone e preencher com menos de 10 caracteres
        var celularInput = driver.FindElement(By.CssSelector("[name='phone']"));
        celularInput.Click();
        celularInput.SendKeys("31986");
    }

    [Then("deve ser exibida a mensagem 'Devem ser informados no mínimo 10 caracteres'")]
    public void EntaoDeveSerExibidaAMensagemDevemSerInformadosNoMinimoDezCaracteres()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector("[id='radix-176-form-item-message']"));

        // Verificar se o texto está correto
        alertElement.Text.Should().Be("Devem ser informados no mínimo 10 caracteres");
    }
}