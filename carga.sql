-- Inserindo dados na tabela Usuarios
INSERT INTO Usuarios (Nome, UserName, Senha, DataCriacao, DataAlteracao, Ativo) VALUES 
('João Silva', 'joaosilva', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', GETDATE(), GETDATE(), 1),
('Maria Souza', 'mariasouza', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', GETDATE(), GETDATE(), 1),
('Carlos Pereira', 'carlosp', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', GETDATE(), GETDATE(), 2);

-- Inserindo dados na tabela Categorias
INSERT INTO Categorias (Nome, Cor, DataCriacao, DataAlteracao, Ativo, UsuarioID) VALUES 
('Alimentação', '#FF5733', GETDATE(), GETDATE(), 1, 1),
('Transporte', '#33FF57', GETDATE(), GETDATE(), 1, 2),
('Lazer', '#3357FF', GETDATE(), GETDATE(), 1, 3);

-- Inserindo dados na tabela Perguntas
-- R1 - Azul
-- R2 - Rex
-- R3 - São Paulo
INSERT INTO Perguntas (Pergunta, Resposta, DataCriacao, UsuarioID) VALUES 
('Qual é a sua cor favorita?', 'b0bf526b23af19619a579501bd7943dd899c211fd2ef69e9f8ab0dc5b43b439a', GETDATE(), 1),
('Qual é o nome do seu primeiro animal de estimação?', '80f1e148f14f3b82aaec65244d7685c1096a8174d748fdc497ecd28ad41ee0b0', GETDATE(), 2),
('Qual é a cidade onde você nasceu?', 'f00fd81daee53caeb98c10457637170f397caf1a97e48e0d2bdcb4cc2639faa4', GETDATE(), 3);

-- Inserindo dados na tabela Movimentacoes
INSERT INTO Movimentacoes (Tipo, Descricao, Valor, DataMovimentacao, DataCriacao, DataAlteracao, Ativo, UsuarioID, CategoriaID) VALUES 
('E', 'Salário', 3000.00, GETDATE(), GETDATE(), GETDATE(), 1, 1, 1),
('S', 'Supermercado', 200.00, GETDATE(), GETDATE(), GETDATE(), 1, 1, 1),
('S', 'Combustível', 150.00, GETDATE(), GETDATE(), GETDATE(), 1, 2, 2),
('E', 'Venda de produto', 500.00, GETDATE(), GETDATE(), GETDATE(), 1, 2, 2),
('S', 'Cinema', 50.00, GETDATE(), GETDATE(), GETDATE(), 1, 3, 3),
('S', 'Restaurante', 100.00, GETDATE(), GETDATE(), GETDATE(), 1, 3, 3),
('S', 'Academia', 80.00, GETDATE(), GETDATE(), GETDATE(), 1, 1, 1),
('S', 'Manutenção do Carro', 300.00, GETDATE(), GETDATE(), GETDATE(), 1, 2, 2),
('E', 'Freelance', 1200.00, GETDATE(), GETDATE(), GETDATE(), 1, 1, 1),
('S', 'Viagem', 1500.00, GETDATE(), GETDATE(), GETDATE(), 1, 3, 3),
('S', 'Roupa', 250.00, GETDATE(), GETDATE(), GETDATE(), 1, 1, 1),
('S', 'Eletrônicos', 800.00, GETDATE(), GETDATE(), GETDATE(), 1, 2, 2),
('E', 'Dividendo de Investimento', 400.00, GETDATE(), GETDATE(), GETDATE(), 1, 2, 2),
('S', 'Assinatura de Streaming', 30.00, GETDATE(), GETDATE(), GETDATE(), 1, 3, 3),
('S', 'Presente', 150.00, GETDATE(), GETDATE(), GETDATE(), 1, 1, 1),
('E', 'Aluguel de Propriedade', 2500.00, GETDATE(), GETDATE(), GETDATE(), 1, 3, 3);


SELECT * FROM Usuarios

SELECT * FROM Categorias

SELECT * FROM Movimentacoes

SELECT * FROM Perguntas


