use projectmia_
GO
SELECT (PrijsIndicatieStuk * Aantalstuk) as Totaal , Financieringsjaar, Titel
from Aanvraag a
WHERE  StatusAanvraagId = 4
AND Financieringsjaar = 2025

SELECT (PrijsIndicatieStuk * Aantalstuk) as Totaal , Titel 
from Aanvraag 
WHERE Financieringsjaar = 2025 AND RichtperiodeId = 13 AND StatusAanvraagId = 4



use projectmia_
GO
SELECT PrijsIndicatieStuk
from Aanvraag
WHERE Financieringsjaar = 2025
AND RichtperiodeId = 13
AND StatusAanvraagId = 4