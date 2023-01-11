// O modificador required pode ser aplucado a campos e propriedades declaradas em structs, classes, record e tipos record struct, 
// mas nao pode ser aplicado a membros de interface.

// Os membros required devem ser inicializados, mas podem ser inicializados como null. Se o tipo for um tipo de referencia nao anulavel,
// o compilador emitira um aviso se voce inicializar o membro como null.

// As classes derivadas nao podem ocultar um membro required declarado na classe base.

// O modificador required nao eh permitido na declaracao de parametros posicionais em um record.

using CSharp_11.RequiredMembers;

// Person maria = new ();
// Person manoel = new Person(name: "Manoel");

Person ana = new Person("Ana", 22);