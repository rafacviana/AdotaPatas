USE [Abrigo];
GO

/* ============================================================
   DADOS DE TESTE - ABRIGO DE ANIMAIS
   15 utilizadores | 30 animais | 15 pessoas
   8 adotantes | 7 voluntarios | 6 funcoes
   30 atividades | 8 processos de adocao | 20 consumiveis
   ============================================================ */

/* -------------------- FUNCOES -------------------- */
INSERT INTO [dbo].[Funcoes] ([Nome]) VALUES
('Tratador de Animais'),
('Passeador'),
('Apoio Veterinario'),
('Coordenador de Abrigo'),
('Apoio Administrativo'),
('Motorista');
GO

/* -------------------- UTILIZADORES -------------------- */
INSERT INTO [dbo].[Utilizadores] ([Utilizador], [Password], [Nome]) VALUES
('teste1', '1234', 'Ana Silva');
GO

/* -------------------- PESSOAS -------------------- */
INSERT INTO [dbo].[Pessoas]
([Nome], [Data_Nascimento], [Morada], [Telemovel], [Email], [Obs:]) VALUES
('Marta Oliveira', '1992-03-14', 'Rua da Liberdade, Lisboa', 912345601, 'marta.oliveira@email.pt', 'Candidata a adocao de cao de porte medio.'),
('Ricardo Almeida', '1987-07-22', 'Rua do Sol, Odivelas', 913456702, 'ricardo.almeida@email.pt', 'Tem experiencia previa com animais.'),
('Catarina Rodrigues', '1995-11-08', 'Rua das Flores, Loures', 914567803, 'catarina.rodrigues@email.pt', 'Procura um gato para companhia.'),
('Nuno Carvalho', '1983-01-30', 'Avenida de Roma, Lisboa', 915678904, 'nuno.carvalho@email.pt', 'Vive numa moradia com espaco exterior.'),
('Joana Teixeira', '1990-05-19', 'Rua do Castelo, Sintra', 916789105, 'joana.teixeira@email.pt', 'Pretende adotar um animal adulto.'),
('Sergio Pinto', '1989-09-03', 'Rua da Escola, Amadora', 917890206, 'sergio.pinto@email.pt', 'Tem outros animais em casa.'),
('Filipa Correia', '1997-12-11', 'Rua do Comercio, Lisboa', 918901307, 'filipa.correia@email.pt', 'Primeira experiencia de adocao.'),
('Hugo Martins', '1985-06-27', 'Rua do Parque, Odivelas', 919012408, 'hugo.martins@email.pt', 'Tem jardim e disponibilidade para acompanhamento.'),
('Laura Ferreira', '1993-02-16', 'Rua da Igreja, Loures', 911123509, 'laura.ferreira@email.pt', 'Voluntaria desde 2024.'),
('Goncalo Ramos', '1991-10-05', 'Rua das Acacias, Lisboa', 922234610, 'goncalo.ramos@email.pt', 'Voluntario com carta de conducao.'),
('Teresa Moreira', '1988-04-21', 'Rua do Pinhal, Sintra', 923345711, 'teresa.moreira@email.pt', 'Experiencia com gatos e pequenos animais.'),
('Filipe Duarte', '1994-08-12', 'Rua do Mercado, Odivelas', 924456812, 'filipe.duarte@email.pt', 'Voluntario com viatura propria.'),
('Daniela Lopes', '1996-01-09', 'Rua da Fonte, Loures', 925567913, 'daniela.lopes@email.pt', 'Disponibilidade principalmente aos fins de semana.'),
('Rui Neves', '1981-11-25', 'Avenida Central, Lisboa', 926678014, 'rui.neves@email.pt', 'Experiencia em transporte de animais.'),
('Patricia Sousa', '1998-06-18', 'Rua dos Cedros, Odivelas', 927789115, 'patricia.sousa@email.pt', 'Voluntaria em passeios e socializacao.');
GO

/* -------------------- ANIMAIS - 30 -------------------- */
INSERT INTO [dbo].[Animais]
([Nome], [Especie], [Genero], [Porte], [Peso], [Idade], [Condicoes_Especiais], [Esteril], [Numero_Chip], [Data_Entrada], [Foto], [Descricao], [Obs]) VALUES
('Bobby', 'Cao', 'Macho', 'Medio', 18.50, '4 anos', 0, 1, 991000001, '2025-02-14', NULL, 'Cao meigo e sociavel, gosta de passeios longos.', 'Adapta-se bem a outros caes.'),
('Luna', 'Cao', 'Femea', 'Medio', 16.20, '3 anos', 0, 1, 991000002, '2025-03-02', NULL, 'Cadela brincalhona e muito afetuosa.', 'Procura familia ativa.'),
('Max', 'Cao', 'Macho', 'Grande', 29.80, '6 anos', 1, 1, 991000003, '2025-03-18', NULL, 'Cao tranquilo e obediente.', 'Tem ligeira dificuldade numa pata traseira.'),
('Nina', 'Gato', 'Femea', 'Pequeno', 4.20, '2 anos', 0, 1, 991000004, '2025-04-06', NULL, 'Gata calma, carinhosa e independente.', 'Gosta de ambientes tranquilos.'),
('Toby', 'Cao', 'Macho', 'Pequeno', 8.40, '5 anos', 0, 1, 991000005, '2025-04-22', NULL, 'Cao pequeno e sociavel.', 'Ideal para apartamento.'),
('Mia', 'Gato', 'Femea', 'Pequeno', 3.80, '1 ano', 0, 0, 991000006, '2025-05-11', NULL, 'Gata jovem e curiosa.', 'Ainda aguarda esterilizacao.'),
('Rex', 'Cao', 'Macho', 'Grande', 31.50, '7 anos', 0, 1, 991000007, '2025-05-27', NULL, 'Cao protetor e muito leal.', 'Precisa de tutor experiente.'),
('Mel', 'Cao', 'Femea', 'Pequeno', 7.10, '3 anos', 0, 1, 991000008, '2025-06-09', NULL, 'Cadela doce e tranquila.', 'Boa com criancas.'),
('Simba', 'Gato', 'Macho', 'Pequeno', 5.00, '4 anos', 0, 1, 991000009, '2025-06-24', NULL, 'Gato sociavel que gosta de colo.', 'Convive bem com outros gatos.'),
('Kika', 'Cao', 'Femea', 'Medio', 13.70, '5 anos', 1, 1, 991000010, '2025-07-03', NULL, 'Cadela calma e obediente.', 'Tem alergia alimentar controlada.'),
('Thor', 'Cao', 'Macho', 'Grande', 34.20, '4 anos', 0, 1, 991000011, '2025-07-19', NULL, 'Cao ativo e brincalhao.', 'Necessita de exercicio diario.'),
('Bela', 'Gato', 'Femea', 'Pequeno', 4.60, '6 anos', 0, 1, 991000012, '2025-08-02', NULL, 'Gata adulta muito tranquila.', 'Prefere ser animal unico.'),
('Pipoca', 'Cao', 'Femea', 'Pequeno', 6.30, '2 anos', 0, 1, 991000013, '2025-08-21', NULL, 'Cadela divertida e carinhosa.', 'Muito sociavel.'),
('Zeca', 'Cao', 'Macho', 'Medio', 20.10, '8 anos', 1, 1, 991000014, '2025-09-10', NULL, 'Cao senior muito afetuoso.', 'Precisa de medicacao diaria.'),
('Amora', 'Gato', 'Femea', 'Pequeno', 3.90, '3 anos', 0, 1, 991000015, '2025-09-28', NULL, 'Gata timida mas carinhosa.', 'Precisa de alguns dias para ganhar confianca.'),
('Nico', 'Cao', 'Macho', 'Medio', 17.40, '1 ano', 0, 0, 991000016, '2025-10-13', NULL, 'Cao jovem cheio de energia.', 'Ainda aguarda esterilizacao.'),
('Sushi', 'Gato', 'Macho', 'Pequeno', 4.10, '2 anos', 0, 1, 991000017, '2025-10-29', NULL, 'Gato brincalhao e curioso.', 'Gosta de brinquedos interativos.'),
('Fiona', 'Cao', 'Femea', 'Grande', 27.60, '5 anos', 0, 1, 991000018, '2025-11-15', NULL, 'Cadela equilibrada e obediente.', 'Boa com pessoas.'),
('Lucky', 'Cao', 'Macho', 'Pequeno', 9.20, '3 anos', 0, 1, 991000019, '2025-12-01', NULL, 'Cao alegre e muito sociavel.', 'Gosta de passeios.'),
('Caju', 'Gato', 'Macho', 'Pequeno', 4.70, '1 ano', 0, 0, 991000020, '2025-12-17', NULL, 'Gato jovem e afetuoso.', 'Aguarda esterilizacao.'),
('Diana', 'Cao', 'Femea', 'Medio', 15.80, '4 anos', 0, 1, 991000021, '2026-01-05', NULL, 'Cadela tranquila e muito companheira.', 'Boa para apartamento espaçoso.'),
('Fred', 'Cao', 'Macho', 'Grande', 26.40, '6 anos', 0, 1, 991000022, '2026-01-19', NULL, 'Cao calmo e protetor.', 'Precisa de passeios regulares.'),
('Lili', 'Gato', 'Femea', 'Pequeno', 3.50, '5 anos', 0, 1, 991000023, '2026-02-03', NULL, 'Gata independente e tranquila.', 'Ideal para pessoa com rotina calma.'),
('Oscar', 'Cao', 'Macho', 'Medio', 19.30, '2 anos', 0, 1, 991000024, '2026-02-18', NULL, 'Cao jovem e brincalhao.', 'Precisa de treino basico.'),
('Estrela', 'Cao', 'Femea', 'Pequeno', 5.90, '7 anos', 1, 1, 991000025, '2026-03-04', NULL, 'Cadela senior muito meiga.', 'Tem problemas ligeiros de visao.'),
('Baltazar', 'Gato', 'Macho', 'Pequeno', 5.20, '3 anos', 0, 1, 991000026, '2026-03-19', NULL, 'Gato muito sociavel e curioso.', 'Convive bem com pessoas.'),
('Margarida', 'Cao', 'Femea', 'Medio', 14.60, '4 anos', 0, 1, 991000027, '2026-04-02', NULL, 'Cadela doce e brincalhona.', 'Boa com outros animais.'),
('Paco', 'Cao', 'Macho', 'Grande', 30.70, '5 anos', 1, 1, 991000028, '2026-04-17', NULL, 'Cao tranquilo e carinhoso.', 'Tem artrose ligeira.'),
('Cleo', 'Gato', 'Femea', 'Pequeno', 4.30, '2 anos', 0, 1, 991000029, '2026-05-03', NULL, 'Gata ativa e brincalhona.', 'Precisa de enriquecimento ambiental.'),
('Romeu', 'Cao', 'Macho', 'Medio', 21.20, '3 anos', 0, 1, 991000030, '2026-05-18', NULL, 'Cao muito afetuoso e sociavel.', 'Gosta de brincar com bolas.');
GO

/* -------------------- ADOTANTES - 8 -------------------- */
INSERT INTO [dbo].[Adotante]
([ID_Pessoa], [BI], [Profissao], [ID_Habitacao], [Espaco_Esterior], [Habitacao_Arrendada], [Autorizacao_Senhorio], [N_Agregados], [Criancas], [Outros_Animais], [Horas_sozinho_dia], [Experiencia_Previa], [Motivo_Adocao], [Aceita_Acompanhamento], [Estado_Candidatura], [Data_Candidatura], [Motivo_Recusa]) VALUES
(1, '12345678', 'Professora', 1, 1, 0, 1, 3, 1, 0, 4, 1, 'Procuramos um companheiro para a familia.', 1, 'Aprovada', '2026-01-12', NULL),
(2, '23456789', 'Engenheiro Informatico', 2, 1, 0, 1, 2, 0, 1, 6, 1, 'Sempre tive animais e quero voltar a ter um cao.', 1, 'Aprovada', '2026-01-21', NULL),
(3, '34567890', 'Designer', 3, 0, 1, 1, 1, 0, 0, 7, 0, 'Procuro companhia para casa.', 1, 'Em analise', '2026-02-06', NULL),
(4, '45678901', 'Contabilista', 4, 1, 0, 1, 4, 1, 0, 3, 1, 'Quero oferecer uma casa a um animal adulto.', 1, 'Aprovada', '2026-02-14', NULL),
(5, '56789012', 'Enfermeira', 5, 1, 1, 1, 2, 0, 0, 5, 1, 'Tenho experiencia com animais e quero adotar.', 1, 'Aprovada', '2026-03-03', NULL),
(6, '67890123', 'Tecnico de Informatica', 6, 0, 0, 1, 2, 0, 1, 9, 1, 'Gostaria de adotar um animal jovem.', 1, 'Recusada', '2026-03-15', 'Numero elevado de horas sozinho.'),
(7, '78901234', 'Assistente Administrativa', 7, 1, 1, 1, 2, 0, 0, 4, 0, 'Quero ter a primeira experiencia de adocao.', 1, 'Em analise', '2026-04-10', NULL),
(8, '89012345', 'Arquiteto', 8, 1, 0, 1, 3, 0, 0, 5, 1, 'Procuro um cao para companhia e passeios.', 1, 'Aprovada', '2026-05-02', NULL);
GO

/* -------------------- VOLUNTARIOS - 7 -------------------- */
INSERT INTO [dbo].[Voluntarios]
([ID_Pessoa], [Data_Inicio], [Data_Fim], [Ativo], [ID_Funcao], [Carta_Conducao], [Viatura], [Contacto_Emergencia_Nome], [Contacto_Emergencia_Telemovel], [Autorizacao_Encarregado]) VALUES
(9, '2024-02-10', NULL, 1, 2, 0, 0, 'Paula Ferreira', 931234501, 1),
(10, '2023-09-15', NULL, 1, 6, 1, 1, 'Carlos Ramos', 932345602, 1),
(11, '2025-01-20', NULL, 1, 3, 0, 0, 'Maria Moreira', 933456703, 1),
(12, '2024-06-05', NULL, 1, 1, 1, 1, 'Helena Duarte', 934567804, 1),
(13, '2025-03-12', NULL, 1, 2, 1, 0, 'Paulo Lopes', 935678905, 1),
(14, '2022-11-08', '2026-02-28', 0, 6, 1, 1, 'Sonia Neves', 936789006, 1),
(15, '2025-08-17', NULL, 1, 2, 0, 0, 'Teresa Sousa', 937890107, 1);
GO

/* -------------------- ATIVIDADES - 30 -------------------- */
INSERT INTO [dbo].[Atividades]
([ID_Animal], [ID_Pessoa], [ID_Funcao], [Data], [Duracao_min], [Obs:]) VALUES
(1, 9, 2, '2026-06-01', 45, 'Passeio no parque e socializacao.'),
(2, 9, 2, '2026-06-01', 40, 'Passeio tranquilo.'),
(3, 12, 1, '2026-06-02', 30, 'Alimentacao e limpeza do espaco.'),
(4, 11, 3, '2026-06-03', 25, 'Administracao de medicacao preventiva.'),
(5, 13, 2, '2026-06-03', 35, 'Passeio e treino de obediencia.'),
(6, 12, 1, '2026-06-04', 30, 'Limpeza da box e alimentacao.'),
(7, 15, 2, '2026-06-05', 50, 'Passeio individual devido ao porte.'),
(8, 9, 2, '2026-06-06', 40, 'Passeio e brincadeira.'),
(9, 11, 3, '2026-06-07', 20, 'Observacao do estado geral.'),
(10, 12, 1, '2026-06-08', 30, 'Preparacao de alimentacao especial.'),
(11, 13, 2, '2026-06-09', 55, 'Passeio longo.'),
(12, 15, 2, '2026-06-10', 30, 'Socializacao com voluntarios.'),
(13, 9, 2, '2026-06-11', 40, 'Passeio no exterior.'),
(14, 11, 3, '2026-06-12', 30, 'Administracao de medicacao diaria.'),
(15, 12, 1, '2026-06-13', 25, 'Limpeza e verificacao de alimentacao.'),
(16, 15, 2, '2026-06-14', 45, 'Passeio e treino basico.'),
(17, 9, 2, '2026-06-15', 35, 'Brincadeira e socializacao.'),
(18, 12, 1, '2026-06-16', 35, 'Higiene e alimentacao.'),
(19, 13, 2, '2026-06-17', 40, 'Passeio no parque.'),
(20, 11, 3, '2026-06-18', 20, 'Observacao de rotina.'),
(21, 15, 2, '2026-06-19', 45, 'Passeio e exercicio.'),
(22, 12, 1, '2026-06-20', 30, 'Limpeza do espaco e alimentacao.'),
(23, 9, 2, '2026-06-21', 35, 'Passeio individual.'),
(24, 13, 2, '2026-06-22', 45, 'Treino de obediencia.'),
(25, 11, 3, '2026-06-23', 30, 'Acompanhamento de problemas de visao.'),
(26, 12, 1, '2026-06-24', 25, 'Limpeza e enriquecimento ambiental.'),
(27, 15, 2, '2026-06-25', 40, 'Passeio e socializacao.'),
(28, 11, 3, '2026-06-26', 30, 'Acompanhamento da artrose.'),
(29, 9, 2, '2026-06-27', 35, 'Brincadeira e passeio.'),
(30, 13, 2, '2026-06-28', 45, 'Passeio e treino com bola.');
GO

/* -------------------- ADOCOES - 8 -------------------- */
INSERT INTO [dbo].[Adocao]
([ID_Animal], [ID_Pessoa], [Atividade], [Data], [Descricao]) VALUES
(1, 1, 'Entrevista', '2026-02-02', 'Entrevista inicial realizada. Familia demonstrou boas condicoes para acolher o animal.'),
(2, 2, 'Visita domiciliaria', '2026-02-08', 'Visita realizada com avaliacao positiva do espaco exterior.'),
(4, 3, 'Conhecimento do animal', '2026-02-20', 'Candidata conheceu a gata e demonstrou interesse na adocao.'),
(7, 4, 'Entrevista', '2026-03-01', 'Candidato demonstrou experiencia previa e disponibilidade.'),
(10, 5, 'Visita domiciliaria', '2026-03-18', 'Casa com espaco adequado e condicoes para dieta especial.'),
(16, 6, 'Analise de candidatura', '2026-03-22', 'Candidatura recusada devido ao elevado numero de horas sozinho.'),
(19, 7, 'Entrevista', '2026-04-18', 'Primeira experiencia de adocao. Processo ainda em analise.'),
(21, 8, 'Visita domiciliaria', '2026-05-10', 'Visita positiva. Familia demonstra boas condicoes para adocao.');
GO

/* -------------------- CONSUMIVEIS - 20 -------------------- */
INSERT INTO [dbo].[Consumiveis]
([Nome], [Especie_Animal], [Tamanho], [Categoria], [Quantidade], [Data_Validade], [Obs]) VALUES
('Racao seca para cao adulto', 'Cao', 'Medio', 'Alimentacao', '25 kg', '2027-06-30', 'Saco fechado para alimentacao diaria.'),
('Racao seca para cao grande', 'Cao', 'Grande', 'Alimentacao', '20 kg', '2027-05-31', 'Adequada para caes de porte grande.'),
('Racao seca para cachorro', 'Cao', 'Pequeno', 'Alimentacao', '10 kg', '2027-04-30', 'Para caes de pequeno porte.'),
('Racao para gato adulto', 'Gato', 'Pequeno', 'Alimentacao', '15 kg', '2027-07-31', 'Alimentacao para gatos adultos.'),
('Racao para gato junior', 'Gato', 'Pequeno', 'Alimentacao', '8 kg', '2027-03-31', 'Para gatos jovens.'),
('Areia aglomerante', 'Gato', 'Pequeno', 'Higiene', '20 kg', '2028-12-31', 'Areia para caixas de gatos.'),
('Resguardos absorventes', 'Cao', 'Pequeno', 'Higiene', '100 unidades', '2028-10-31', 'Utilizados nas boxes e quarentena.'),
('Champô dermatologico', 'Cao', 'Todos', 'Higiene', '12 frascos', '2027-11-30', 'Para animais com pele sensivel.'),
('Champô suave', 'Cao', 'Todos', 'Higiene', '15 frascos', '2028-01-31', 'Uso geral.'),
('Desinfetante veterinario', 'Todos', 'Todos', 'Limpeza', '10 litros', '2028-08-31', 'Utilizado na higienizacao das boxes.'),
('Luvas descartaveis', 'Todos', 'Todos', 'Protecao', '500 unidades', '2029-12-31', 'Luvas para limpeza e cuidados.'),
('Gaze esteril', 'Todos', 'Todos', 'Primeiros socorros', '200 unidades', '2029-09-30', 'Material de primeiros socorros.'),
('Ligaduras', 'Todos', 'Todos', 'Primeiros socorros', '50 unidades', '2029-09-30', 'Material para pequenos tratamentos.'),
('Toalhitas de limpeza', 'Cao', 'Todos', 'Higiene', '100 unidades', '2028-06-30', 'Para limpeza das patas e pelo.'),
('Escovas para pelo', 'Cao', 'Todos', 'Higiene', '12 unidades', NULL, 'Escovas de varios tamanhos.'),
('Areia sanitaria', 'Gato', 'Pequeno', 'Higiene', '40 kg', '2028-11-30', 'Stock para caixas sanitarias.'),
('Latas de comida humida', 'Cao', 'Todos', 'Alimentacao', '48 unidades', '2027-08-31', 'Utilizadas como complemento alimentar.'),
('Latas de comida humida', 'Gato', 'Todos', 'Alimentacao', '60 unidades', '2027-09-30', 'Alimentacao humida para gatos.'),
('Brinquedos de borracha', 'Cao', 'Medio', 'Enriquecimento', '20 unidades', NULL, 'Brinquedos para exercicio e estimulacao.'),
('Brinquedos interativos', 'Gato', 'Pequeno', 'Enriquecimento', '15 unidades', NULL, 'Brinquedos para estimular os gatos.');
GO

/* -------------------- CONSULTAS DE CONFIRMACAO -------------------- */
SELECT 'Utilizadores' AS Tabela, COUNT(*) AS Total FROM [dbo].[Utilizadores]
UNION ALL
SELECT 'Animais', COUNT(*) FROM [dbo].[Animais]
UNION ALL
SELECT 'Pessoas', COUNT(*) FROM [dbo].[Pessoas]
UNION ALL
SELECT 'Adotantes', COUNT(*) FROM [dbo].[Adotante]
UNION ALL
SELECT 'Voluntarios', COUNT(*) FROM [dbo].[Voluntarios]
UNION ALL
SELECT 'Funcoes', COUNT(*) FROM [dbo].[Funcoes]
UNION ALL
SELECT 'Atividades', COUNT(*) FROM [dbo].[Atividades]
UNION ALL
SELECT 'Adocoes', COUNT(*) FROM [dbo].[Adocao]
UNION ALL
SELECT 'Consumiveis', COUNT(*) FROM [dbo].[Consumiveis];
GO
