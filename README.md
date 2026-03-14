# Prosty Kalkulator

# Odpowiedzi na pytania końcowe

**1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?**
* **Fast-forward:** Wykonywany, kiedy na gałęzi docelowej (np. main) nie pojawiły się nowe commity od chwili rozpoczęcia pracy z gałęzią boczną (zwykłe przesunięcie wskaźnika HEAD).
* **Merge commit:** Jest tworzony, kiedy na dwóch gałęziach pojawiły się niezależne zmiany. Git tworzy "merge commit", który łączy zmiany oby ze swoich rodziców.

**2. Czym w praktyce różni się merge od rebase?**
* **Merge** zachowuje oryginalną historię i chronologię, pozostawiając ślady pracy na osobnych gałęziach (i kiedy zostały one połączone).
* **Rebase** przepisuje historię, lecz zamiast łączyć gałęzie skleja je w "jedną linię" - tzn. aktualizuje bazę do najnowszego stanu głównej gałęzi, doklejając commity z bocznej gałęzi na sam szczyt (zmieniane są identyfikatory commitów). 

**3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?**
Został on rozwiązany przez odpowiednią decyzję w sprawie zmian w pliku 'Program.cs'. Konflikt polegał na wyborze sposobu wybierania operacji do wykonania na podstawie danych wejściowych - czy liczyć średnią, czy coś innego. Był to wybór między oznaczeniami opcji - 1-2-3 albo a-b-c. Problem został rozwiązany przez usunięcie znaczników Gita, symbolizujące części z odpowienich gałęzi i wybór jednej z nich (tutaj opcji numerycznej) poprzez commit.