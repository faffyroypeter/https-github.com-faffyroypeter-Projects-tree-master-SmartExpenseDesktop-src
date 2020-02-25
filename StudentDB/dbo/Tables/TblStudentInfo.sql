CREATE TABLE [dbo].[TblStudentInfo] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [RoleNo]    NVARCHAR (255) NOT NULL,
    [FirstName] NVARCHAR (255) NOT NULL,
    [LastName]  NVARCHAR (255) NOT NULL,
    [City]      NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

