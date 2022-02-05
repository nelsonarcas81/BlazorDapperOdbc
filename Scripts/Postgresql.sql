-- Table: public.equipe

-- DROP TABLE IF EXISTS public.equipe;

CREATE TABLE IF NOT EXISTS public.equipe
(
    id character varying(12) COLLATE pg_catalog."default" NOT NULL,
    descricao character varying(30) COLLATE pg_catalog."default" NOT NULL,
    dtcadastro date,
    CONSTRAINT equipe_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.equipe
    OWNER to postgres;