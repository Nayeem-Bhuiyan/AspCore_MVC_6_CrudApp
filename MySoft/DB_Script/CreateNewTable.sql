CREATE TABLE [Country] (
          [Id] int NOT NULL IDENTITY,
          [name] nvarchar(50) NOT NULL,
          [countryCode] nvarchar(25) NULL,
          CONSTRAINT [PK_Country] PRIMARY KEY ([Id])
      );


 CREATE TABLE [Employee] (
          [Id] int NOT NULL IDENTITY,
          [name] nvarchar(100) NOT NULL,
          [employeeCode] nvarchar(25) NULL,
          [address] nvarchar(250) NULL,
          [contactNumber] nvarchar(25) NULL,
          [joiningDate] Date NULL,
          [isActive] bit NOT NULL,
          [CountryId] int NOT NULL,
          CONSTRAINT [PK_Employee] PRIMARY KEY ([Id]),
          CONSTRAINT [FK_Employee_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([Id]) ON DELETE CASCADE
      );