Am identificat 3 contexte.
I. Decanat
Din punctul meu de vedere acesta are trei atributii:
 1) Definire discipline si profesori pt fiecare disciplina
Puncte de interes sunt profesorul (nume) si SubjectInformation (unde se vor atribui credite, nume, etc)
 2) Alocare discipline student astfel incat acesta sa aibe 60 credite
 Puncte de interes sunt SubjectInformation si studentul doar cu numele si regNumber
 3) Generare rapoarte
Puncte de interes sunt GradeReport, EvalType, Credits, Professor,ActivityProportion din SubjectInformation si Student (GetAverageForStudent si GetSituationForStudent)

II. Profesor
1) Consultare lista discipline + definire proportie activitate pe parcurs
 Puncte de interes: Professor si Subject doar cu SetActivityProp si List<AllSubjects>
2) Adauga note (+mariri)
Puncte de interes sunt Student cu nume si RegNr, Professor si Subject cu Subject Situation

III. Student
1) Vizualizare situatie proprie
De interes este tot ce tine de entitatea student si EvalType, Credits, Professor,ActivityProportion din SubjectInformation