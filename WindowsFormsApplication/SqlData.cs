using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    class SqlData
    {


        //-----------Tuesday, 8 May 2018--------------------------

        /*      USE[VcSharpDB]
      GO

              SET ANSI_NULLS ON
              GO
              SET QUOTED_IDENTIFIER ON
              GO
              create procedure[dbo].[usp_StudentInsertDetails]
              (
              @Name nvarchar(50),
              @Email nvarchar(50),
              @IsInterestedInCSharp bit,
              @IsInterestedInVb bit,
              @IsInterestedInSql bit,
              @GenderId int,
              @DateOfBirth datetime = null,
              @StartTime datetime = null,
              @EndTime datetime = null
              )
              as 
              begin
              INSERT INTO[dbo].[Students]
                         ([Name]
                         ,[Email]
                         ,[IsInterestedInCSharp]
                         ,[IsInterestedInVb]
                         ,[IsInterestedInSql]
                         ,[GenderId]
                         ,[DateOfBirth]
                         ,[StartTime]
                         ,[EndTime])
                   VALUES
                         (@Name,
                         @Email,
                         @IsInterestedInCSharp,
                         @IsInterestedInVb,
                         @IsInterestedInSql,
                         @GenderId,
                         @DateOfBirth,
                         @StartTime,
                         @EndTime

                         )
              end
      */

        //------------------------------------

        /*    alter procedure usp_GetAllListData
              (
              @ListDataTypeId Int
              )
              as 
              begin
              select[ListDataId],[Description] from[dbo].[ListData]
              where[ListDataTypeId] = @ListDataTypeId
      end
      */

        //-------------------------------------

        /*       USE[VcSharpDB]
        GO


        SET ANSI_NULLS ON
        GO

        SET QUOTED_IDENTIFIER ON
        GO

        CREATE TABLE[dbo].[ListData](
            [ListDataId]
                [int] IDENTITY(1,1) NOT NULL,

        [Description] [nvarchar](50) NOT NULL,


        [ListDataTypeId] [int] NULL,
         CONSTRAINT[PK_ListData] PRIMARY KEY CLUSTERED
        (
           [ListDataId] ASC
        )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
        ) ON[PRIMARY]

        GO
        */

        //-------------------------------------

        /*      USE[VcSharpDB]
      GO


      SET ANSI_NULLS ON
      GO

      SET QUOTED_IDENTIFIER ON
      GO

      CREATE TABLE[dbo].[ListDataType1](
          [ListDataTypeId]
              [int] IDENTITY(1,1) NOT NULL,

      [Description] [nvarchar](50) NOT NULL,
      CONSTRAINT[PK_ListDataType1] PRIMARY KEY CLUSTERED
      (
      [ListDataTypeId] ASC
      )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
      ) ON[PRIMARY]

      GO
      */

        //-------------------------------------

        /*  USE[VcSharpDB]
        GO


          SET ANSI_NULLS ON
          GO

          SET QUOTED_IDENTIFIER ON
          GO

          CREATE TABLE[dbo].[Students](
              [StudentId]
          [int] IDENTITY(1,1) NOT NULL,


        [Name] [nvarchar](50) NOT NULL,


        [Email] [nvarchar](50) NULL,
              [IsInterestedInCSharp]
          [bit]
          NULL,
              [IsInterestedInVb]
          [bit]
          NULL,
              [IsInterestedInSql]
          [bit]
          NULL,
              [GenderId]
          [int] NULL,
              [DateOfBirth]
          [datetime]
          NULL,
              [StartTime]
          [datetime]
          NULL,
              [EndTime]
          [datetime]
          NULL,
           CONSTRAINT[PK_Students] PRIMARY KEY CLUSTERED
          (
             [StudentId] ASC
          )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
          ) ON[PRIMARY]

          GO

            */

        //-------------------------------------


    }
}
