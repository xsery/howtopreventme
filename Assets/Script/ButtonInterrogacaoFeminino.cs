using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInterrogacaoFeminino : MonoBehaviour {

    private bool condicao;
    public bool terminou;
    public GameObject objeto;

    public Text balao;
    public Text tema;
    public Text pop;
    public int contFala;

    // Use this for initialization
    void Start()
    {
        condicao = false;
        terminou = false;
        contFala = -1;
    }

    // Update is called once per frame
    void Update()
    {
        objeto.SetActive(condicao);
    }

    public void mudar()
    {
        condicao = !condicao;
    }

    public void trocaDeFala()
    {
        contNemFala();
        if (contFala == 0)
        {
            balao.text = "AJUDA\nOs ovários\nsão dois\norgãos de\nforma oval\nque\nmedem de\n3 a 4 cm.";
            tema.text = "Clique no OVÁRIO";
            pop.text = "Os ovários são estruturas relacionadas com\na produção de hormônios e com a formação de\n" +
                "células reprodutivas, chamadas popularmente de óvulos. Próximo...";
        }
        if (contFala == 1)
        {
            balao.text = "AJUDA\nO útero é\num órgão\nmuscular\noco, do\ntamanho e\nforma\nsemelhante\na uma pera\n" +
                "invertida.";
            tema.text = "Clique no ÚTERO";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Quando o espermatozóide fecunda o\nóvulo, geram o embrião que se\ndesenvolverá no utero. Próximo...";
        }
        if (contFala == 2)
        {
            balao.text = "AJUDA\nTubas\nuterinas são\ndois tubos,\ncom mais ou\nmenos 10 cm\nde\ncomprimento,\nque unem os\novários ao\n" +
                "útero.";
            tema.text = "Clique na TUBA UTERINA";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Pelas tubas os espermatozoides passam\nem direção oposta ao óvulo, sendo nela que,\nocorre a fecundação. Próximo...";
        }
        if (contFala == 3)
        {
            balao.text = "AJUDA\nO colo do\nútero é a\nporção\ninferior do\nútero onde\nse encontra\na abertura\ndo órgão,\nlocalizando-\n" +
                "se no fundo\nda vagina.";
            tema.text = "Clique na COLO DO UTERO";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Localizado no fundo da vagina, é por\nonde saí a menstruação e entra o\nespermatozóide. E é por onde passa o\n" +
                "bebê no parto normal. Próximo...";
        }
        if (contFala == 4)
        {
            balao.text = "AJUDA\nA vagina é\num canal\nque fez a\ncomunica-\nção do útero\ncom o meio\nexterior.";
            tema.text = "Clique no VAGINA";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Recebe o pênis durante o sexo, dá saída\nao bebê durante o parto normal e expele" +
                "\no sangue da menstruação";
        }

    }

    public void contNemFala()
    {
        if (contFala >= 4)
        {
            GameManager.Instance.ganhaUmPonto();
            terminou = true;
            contFala = 0;
        }
        else
        {
            contFala++;
        }
    }
}
