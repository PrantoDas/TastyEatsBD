
DECLARE @IMG1 VARCHAR(600) = 'C:\StorageFolder\1-10-2024\chickenbiryanibowltop.jpg';
DECLARE @IMG2 VARCHAR(600) = 'C:\StorageFolder\1-10-2024\f8d435c0-d378-11ec-ac3c-451e8527e644.png';
DECLARE @IMG3 VARCHAR(600) = 'C:\StorageFolder\1-10-2024\lamb-biryani-hero-01-SEA-QIAi-hero-bc09dcc1348f4876bdd2fa1e1a5f918c.PNG';

-- Update Items table to set PhotoURL to a randomly chosen image path
UPDATE Items
SET PhotoURL = CASE ABS(CAST(CAST(NEWID() AS VARBINARY) AS INT)) % 3
                        WHEN 1 THEN @IMG1
                        WHEN 2 THEN @IMG2
						ELSE		@IMG3
               END

-- Update Accounts table to set ProfileImageURL to a randomly chosen image path
UPDATE Accounts
SET ProfileImageURL = CASE ABS(CAST(CAST(NEWID() AS VARBINARY) AS INT)) % 3
                        WHEN 1 THEN @IMG1
                        WHEN 2 THEN @IMG2
						ELSE		@IMG3
					  END
WHERE AccountType = 1;