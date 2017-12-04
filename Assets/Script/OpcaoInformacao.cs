using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpcaoInformacao : MonoBehaviour {

    public GameObject Cena1;
    public GameObject Cena1UI;
    public GameObject Cena2;
    public GameObject ButtonProximo;
    public GameObject SemInformacoes;
    public GameObject SemInformacoesUI;
    public GameObject PopUp;
    public GameObject Button;
    public GameObject ButtonMapa;
    public Text balao;
    public Text pop;

    // Use this for initialization
    void Start()
    {
        Cena1.SetActive(true);
        Cena1UI.SetActive(true);
        ButtonProximo.SetActive(true);
        Cena2.SetActive(false);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(false);
        Button.SetActive(false);
        ButtonMapa.SetActive(true);
        balao.text = "Olá, você está na CASA DA AIDS!\nGostaria de saber mais sobre o HIV/Aids?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void proximo()
    {
        balao.text = "Volte sempre à CASA DA AIDS para tirar as\nsuas dúvidas! Até breve";
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(true);
        SemInformacoesUI.SetActive(true);
        PopUp.SetActive(false);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
    }

    public void mapa()
    {
        Cena1.SetActive(true);
        Cena1UI.SetActive(true);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(false);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(false);
        Button.SetActive(false);
        ButtonMapa.SetActive(false);
        StartCoroutine("sceneMapa");
    }

    IEnumerator sceneMapa()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Scene/Mapa");
    }

    public void opcao1()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "O HIV(Vírus da Imunodeficiência\nAdquirida) é o vírus causador da Aids\n(Síndrome da " +
            "Imunodeficiência\nAdquirida).\nO vírus se instala nas células de defesa\ndo corpo, as células" +
            " se multiplicam e se\nespalham pelo sangue, contaminando\noutras células.\nEsse vírus prejudica " +
            "a defesa do\norganismo, possibilitando o\naparecimento de vários tipos de\ndoença.\nA Aids se" +
            "manisfesta após a infecção do\norganios humano pelo HIV. Uma\npessoa pode ter o vírus e não\n" +
            "manifestar a doença.";
    }

    public void opcao2()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "-> Fazendo sexo homo ou heterossexual\nsem camisinha (oral, vagina ou anal)\ncom pessoa " +
            "infectada;\n\n-> Compartilhando agulhas e seringas\ncontaminadas;\n\n-> Da mãe para o bebê durante a\n" +
            "gravidez, na hora do pacto e/ou\namamentação.\n\n-> Transfusão de sangue contaminado\npelo HIV.\n\n" +
            "-> Reutilização de objetos cortantes com\npresença de sangue ou fluidos\ncontaminados pelo HIV.\ndoença.";
    }

    public void opcao3()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "-> Para previnir a transmissão,\nrecomenda-se o uso de camisinha\ndurante todas as relações sexuais." +
            "\n\n-> As seringas e agulhas devem ser\ndescartávies.\n\n-> Para fazer a transfusão de sangue, é\n" +
            "feito um teste e análise do sangue a\nser usado.\n\n-> Mães infectadas pelo vírus devem\nusar antirretroviral" +
            " enquanto está\ngrávida para evitar transmitir para o neném e também evitar amamentá-\nlo.";
    }

    public void opcao4()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "Existe a Profilaxia Pós-Exposição. é uma\nforma de prevenção da infecção pelo\nHIV usando o coquetel " +
            "utilizado no\ntratamento da Aids, para pessoas que\npossam ter entrado em contato com o\nvírus recentemente." +
            "\n\nPreciso ser tomado por 28 dias, para\nimpedir a infecção pelo vírus, sempre\ncom orientação médica.\n\n" +
            "O ideal é que se comece a tomar em\nATÉ 72 horas de possível exposição ao\nvírus HIV. Pode trazer efeitos" +
            "colaterais\ngraves e perde a eficácia se ingerida\nrepetidas vezes.";
    }

    public void opcao5()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "A infecção pelo HIV pode ser detectada\npelo exame de sangue a partir de 30\ndias de situação de risco." +
            "\n\nOs testes são realizados nos Centros de\nTestagem e Aconselhamento(CTA),\npelo Sistema Único de SAÚDE" +
            " (SUS) e nas unidades da rede pública.\n Também é possível saber onde fazer o\nteste pelo Disque Saúde (136)." +
            "\n\nO teste é gratuito, rápido e detecta a\npresença do vírus em até 30 minutos,\ncom apenas uma gota de sangue" +
            "da\nponta do dedo.";
    }

    public void opcao6()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "Os primeiros sintomas são muito\nparecidos com os de uma gripe, como\nfebre e mal-estar que surgem de duas" +
            "\na quatro semanas após a\ncontaminação.\n\nPor isso, a maioria dos casos passa despercebido. Caso haja suspeitas de" +
            "\ninfecção pelo HIV, procure uma\nUnidade de Saúde mais próxima e\nrealize o teste.\n\nCerca de 70% dos portadores\n" +
            "permanece de duas a três décadas na\nchamada forma assintomática ou\nindeterminada da doença.";
    }

    public void opcao7()
    {
        Cena1.SetActive(false);
        Cena1UI.SetActive(false);
        ButtonProximo.SetActive(false);
        Cena2.SetActive(true);
        SemInformacoes.SetActive(false);
        SemInformacoesUI.SetActive(false);
        PopUp.SetActive(true);
        Button.SetActive(true);
        ButtonMapa.SetActive(true);
        pop.text = "Atualmente, a Aids não tem cura, mas\ntem tratamento através do coquetel,\nde maneira que uma pessoa " +
            "infectada\npode viver com o vírus HIV por um\nlongo período, sem apresentar sintoma.\n\nQuanto mais cedo a" +
            " presença do vírus\nfor detectada, mais eficiente poderá\nser o tratamento.\n\nA meditação diminui a multi" +
            "plicação\ndo vírus no corpo e recupera as\ndefesas do organismo, aumentando a\nqualidade de vida do soropositivo.";
    }
}
