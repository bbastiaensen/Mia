use projectmia_
GO
SELECT SUM(PrijsIndicatieStuk * AantalStuk)
from Aanvraag
WHERE Financieringsjaar = 2025
AND RichtperiodeId = 13
AND StatusAanvraagId = 4
use projectmia_
GO
SELECT PrijsIndicatieStuk
from Aanvraag
WHERE Financieringsjaar = 2025
AND RichtperiodeId = 13
AND StatusAanvraagId = 4