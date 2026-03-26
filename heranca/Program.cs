PessoaFisica pessoa1 = new PessoaFisica();
pessoa1.nome = "Carlos";
pessoa1.endereco = "112";
pessoa1.cpf = "532";

PessoaJuridica pessoaJ1 = new PessoaJuridica();
pessoaJ1.nome = "alguma coisa";
pessoaJ1.endereco = "3f32";
pessoaJ1.cnpj = "333d";

Conta conta01 = new Conta();
conta01.abrirConta(pessoa1);
conta01.abrirConta(pessoaJ1);
