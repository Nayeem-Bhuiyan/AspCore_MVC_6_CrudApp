CREATE TABLE [Country] (
          [Id] int NOT NULL IDENTITY,
          [name] nvarchar(max) NULL,
          [countryCode] nvarchar(max) NULL,
          CONSTRAINT [PK_Country] PRIMARY KEY ([Id])
      );


	  CREATE TABLE [Employee] (
          [Id] int NOT NULL IDENTITY,
          [name] nvarchar(max) NULL,
          [employeeCode] nvarchar(max) NULL,
          [address] nvarchar(max) NULL,
          [contactNumber] nvarchar(max) NULL,
          CONSTRAINT [PK_Employee] PRIMARY KEY ([Id])
      );