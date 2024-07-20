namespaceLHPet.Models;

publicclassCliente
    {
/* No trecho de código a seguir são criados os atributos de Cliente e seus getterse setterscorrespondentes. */
        publicintId{ get; set; }
        publicstringNome{ get; set; }
        publicstringCpf{ get; set; }
        publicstringEmail{ get; set; }
        publicstringPaciente{ get; set; }
/* Nesse trecho do código, é criado o Construtor do model Cliente e determinado quais parâmetros são necessários na criação das instâncias. */
publicCliente(intid, stringnome, stringcpf, stringemail, stringpaciente)
    {
        this.Id= id;
        this.Nome= nome;
        this.Cpf= cpf;
        this.Email= email;
        this.Paciente= paciente;
    }
}

