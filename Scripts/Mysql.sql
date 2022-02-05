CREATE TABLE `equipe` (
  `id` varchar(12) NOT NULL,
  `descricao` varchar(30) DEFAULT NULL,
  `dtcadastro` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
