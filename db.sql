DROP TABLE IF EXISTS TRANSACAO;
DROP TABLE IF EXISTS CLIENTE;
CREATE TABLE CLIENTE(
	"id" SERIAL NOT NULL,
	"limite" INT NOT NULL,
	"saldo_inicial" INT NOT NULL,
	
	CONSTRAINT "pk_cliente" PRIMARY KEY ("id")
);

CREATE TABLE TRANSACAO (
	"id_cliente" INT NOT NULL,
	"descricao" VARCHAR(10) NOT NULL,
	"valor" INT NOT NULL,
	"tipo" VARCHAR(1) NOT NULL,
	"feita_em" TIMESTAMP NOT NULL,
	
	CONSTRAINT "fk_transacao" FOREIGN KEY ("id_cliente") REFERENCES "cliente"("id")
);

INSERT INTO cliente ("limite", "saldo_inicial") VALUES 
(100000, 0),
(80000, 0),
(1000000, 0),
(10000000, 0),
(500000, 0);
