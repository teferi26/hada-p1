P1 -> ¿Qué crees que significa la opción -n den el comando revert?

-	En el comando (git revert -help) nos comenta que -n es una de las 2 maneras 
	de conseguir que no haga commmit automáticamente. La otra sería --no-commit

P2 -> ¿Qué cambios se ha producido al ejecutar el comando reset?

-	Que el HEAD se ha movido ahora al anterior commit, y ha deshecho el último
	commit por lo tanto se ha vuelto a eliminar readme.txt

P3 ->¿Qué diferencias observas entre revert y reset? 

-	Revert se utiliza para deshacer cambios de una manera que no altera el 
	historial de commits. Esto significa que, en lugar de eliminar commits, 
	revert agrega un nuevo commit que invierte los cambios realizados por 
	commits anteriores.

-	El comando reset se utiliza para restablecer el estado del repositorio a un 
	commit anterior, eliminando commits posteriores a ese punto. Es una manera de 
	"borrar" cambios en el historial de tu proyecto.

P4 -> ¿Qué diferencias observas entre merge y rebase?

-	Merge preserva el historial exacto de las ramas, incluyendo cómo y cuándo se 
	integraron las características. Esto puede resultar en un historial más 
	complejo, pero refleja con precisión el proceso de desarrollo.

-	Rebase ofrece un historial más limpio y lineal, lo que puede simplificar la 
	comprensión de la secuencia de cambios. Sin embargo, al reescribir el historial, 
	puede complicar el trabajo colaborativo si no se usa con cuidado.
