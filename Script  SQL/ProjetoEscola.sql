use projetoescola;

/* ------------------------------------------------------------------ */

CREATE TABLE Nivel_Acesso(
	cd_nivel INT auto_increment,
    dsc_nivel VARCHAR(50) NOT NULL,
    CONSTRAINT nivelacesso_pk PRIMARY KEY(cd_nivel)
);


CREATE TABLE Usuario(
	username VARCHAR(100),
    senha VARCHAR(100) NOT NULL,
    cd_nivel INT,
    statuss Boolean,
    CONSTRAINT usuario_pk PRIMARY KEY(username),
    CONSTRAINT usuario_fk FOREIGN KEY(cd_nivel) REFERENCES Nivel_Acesso(cd_nivel)
);

CREATE TABLE Turma(
	cd_turma INT,
    nu_turma VARCHAR(10),
    sg_turma VARCHAR(10),
    CONSTRAINT turma_pk PRIMARY KEY(cd_turma)
);

CREATE TABLE Diretoria(
	cpf_direcao VARCHAR(100),
    nm_direcao VARCHAR(100),
    sb_direcao VARCHAR(100),
    dt_nascimento_direcao DATE,
    username VARCHAR(100),
    CONSTRAINT diretoria_pk PRIMARY KEY(cpf_direcao),
    CONSTRAINT diretoria_fk FOREIGN KEY(username) REFERENCES Usuario(username)
);

CREATE TABLE Professor(
	cpf_professor VARCHAR(100),
    nm_professor VARCHAR(100),
    sb_professor VARCHAR(100),
    dt_nascimento_professor DATE,
    username VARCHAR(100),
    CONSTRAINT professor_pk PRIMARY KEY(cpf_professor),
    CONSTRAINT professor_fk FOREIGN KEY(username) REFERENCES Usuario(username)
);

CREATE TABLE Categoria_Auxiliar(
	cd_categoria INT auto_increment,
    dsc_categoria VARCHAR(100) NOT NULL,
    CONSTRAINT categoriaauxiliar_pk PRIMARY KEY(cd_categoria)
);

CREATE TABLE Auxiliar(
	cpf_auxiliar VARCHAR(100),
    nm_auxiliar VARCHAR(100),
    sb_auxiliar VARCHAR(100),
    dt_nascimento_auxiliar DATE,
    cd_categoria INT,
    CONSTRAINT auxiliar_pk PRIMARY KEY(cpf_auxiliar),
    CONSTRAINT auxiliar_fk FOREIGN KEY(cd_categoria) REFERENCES Categoria_Auxiliar(cd_categoria)
    
);

CREATE TABLE Aluno(
	ra_aluno VARCHAR(100),
    nm_aluno VARCHAR(100),
    sb_aluno VARCHAR(100),
    dt_nascimento_aluno DATE,
    username VARCHAR(100),
    cd_turma INT,
    CONSTRAINT aluno_pk PRIMARY KEY(ra_aluno),
    CONSTRAINT aluno_fk FOREIGN KEY(cd_turma) REFERENCES Turma(cd_turma)
);

CREATE TABLE Professor_Turma(
	cd_prof_turma INT auto_increment,
    cpf_professor VARCHAR(100),
    cd_turma INT,
    CONSTRAINT professorturma_pk PRIMARY KEY(cd_prof_turma),
    CONSTRAINT professorturma_fk1 FOREIGN KEY(cpf_professor) REFERENCES Professor(cpf_professor),
    CONSTRAINT professorturma_fk2 FOREIGN KEY(cd_turma) REFERENCES Turma(cd_turma)
    
);

CREATE TABLE Categoria_Disciplina(
	cd_categoria_disciplina int auto_increment,
    dsc_categoria_disciplina VARCHAR(50) NOT NULL,
    CONSTRAINT categoriadisciplina_pk PRIMARY KEY(cd_categoria_disciplina),
    CONSTRAINT categoriadiscplina_uk UNIQUE(dsc_categoria_disciplina)
);

CREATE TABLE Disciplina(
	cd_disciplina INT auto_increment,
    nm_disciplina VARCHAR(100),
    cd_categoria_disciplina int,
    CONSTRAINT disciplina_pk PRIMARY KEY(cd_disciplina),
    CONSTRAINT disciplina_fk FOREIGN KEY(cd_categoria_disciplina)
    REFERENCES Categoria_Disciplina(cd_categoria_disciplina)
);

CREATE TABLE Professor_Disciplina(
	cd_professor_disciplina INT,
    cpf_professor VARCHAR(100),
    cd_disciplina INT,
    CONSTRAINT professordisciplina_pk PRIMARY KEY(cd_professor_disciplina),
    CONSTRAINT professordisciplina_fk1 FOREIGN KEY(cpf_professor) REFERENCES Professor(cpf_professor),
    CONSTRAINT professordisciplina_fk2 FOREIGN KEY(cd_disciplina) REFERENCES Disciplina(cd_disciplina)
);

CREATE TABLE Bimestre(
	cd_bimestre INT,
    nu_bimestre VARCHAR(100) NOT NULL,
    CONSTRAINT bimestre_pk PRIMARY KEY(cd_bimestre),
    CONSTRAINT bimestre_uq UNIQUE(nu_bimestre)
);

CREATE TABLE Aluno_Nota(
	cd_aluno_nota INT auto_increment,
    ra_aluno VARCHAR(100),
    cd_disciplina INT,
    cd_bimestre INT,
    CONSTRAINT alunonota_pk PRIMARY KEY(cd_aluno_nota),
    CONSTRAINT alunonota_fk1 FOREIGN KEY(cd_disciplina) REFERENCES Disciplina(cd_disciplina),
    CONSTRAINT alunonota_fk2 FOREIGN KEY(cd_bimestre) REFERENCES Bimestre(cd_bimestre)
);

CREATE TABLE Falta(
	cd_falta INT auto_increment,
    ra_aluno VARCHAR(100),
    cd_bimestre INT,
    qtde_falta INT,
    CONSTRAINT falta_pk PRIMARY KEY(cd_falta),
    CONSTRAINT falta_fk1 FOREIGN KEY(ra_aluno) REFERENCES Aluno(ra_aluno),
    CONSTRAINT falta_fk2 FOREIGN KEY(cd_bimestre) REFERENCES Bimestre(cd_bimestre)
);

/* ------------------------------------------------------------------ */

INSERT INTO Nivel_Acesso(dsc_nivel)
VALUES('Diretoria');
INSERT INTO Nivel_Acesso(dsc_nivel)
VALUES('Professor');
INSERT INTO Nivel_Acesso(dsc_nivel)
VALUES('Aluno');

INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(111,'1','A');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(222,'1','B');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(333,'1','C');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(444,'2','A');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(555,'2','B');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(666,'2','C');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(777,'3','A');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(888,'3','B');
INSERT INTO Turma(cd_turma,nu_turma,sg_turma)
VALUES(999,'3','C');

INSERT INTO Categoria_Disciplina(dsc_categoria_disciplina)
VALUES('Humanas');
INSERT INTO Categoria_Disciplina(dsc_categoria_disciplina)
VALUES('Exatas');
INSERT INTO Categoria_Disciplina(dsc_categoria_disciplina)
VALUES('Biológicas');
INSERT INTO Categoria_Disciplina(dsc_categoria_disciplina)
VALUES('Idiomas');

INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Português',1);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Matemática',2);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('História',1);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Geografia',1);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Biologia',3);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Filosofia',1);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Sociologia',1);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Inglês',4);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Espanhol',4);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Química',2); 
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Física', 2);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Educação Física',3);
INSERT INTO Disciplina(nm_disciplina,cd_categoria_disciplina)
VALUES('Artes',1);

INSERT INTO Bimestre(cd_bimestre,nu_bimestre)
VALUES(111,'1º Bimestre');
INSERT INTO Bimestre(cd_bimestre,nu_bimestre)
VALUES(222,'2º Bimestre');
INSERT INTO Bimestre(cd_bimestre,nu_bimestre)
VALUES(333,'3º Bimestre');
INSERT INTO Bimestre(cd_bimestre,nu_bimestre)
VALUES(444,'4º Bimestre');

INSERT INTO Usuario(username,senha,cd_nivel,statuss)
VALUES('diretoria111','primeirodiretor',1,true);
INSERT INTO Diretoria(cpf_direcao,nm_direcao,sb_direcao,dt_nascimento_direcao,username)
VALUES('111.111.111-11','Ana','Martinelli','1978-09-05','diretoria111');


CATEGORIA_AUXILIAR
