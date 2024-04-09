# Object Calisthenics

A repository to expose Object Calisthenics, Law of Demeter (LoW), "Tell don't ask" (TDA) approaches.
See code to illustrate rules below.

_(in french below...)_

# Objectif

L'objectif de ce document est de vous présenter différentes approches pour coder selon des approches industrielles éprouvées. Nous ne parlerons pas ici de Design-Patterns d'architecture mais bien de la pratique concrète du codage.

# Thématiques visées

Nous verrons les thématiques suivantes qui peuvent se recouper :
- Rappels SOLID
- Object Calisthenics
- Loi de Demeter
- Approche "Tell don't ask"
- Composition over Inheritance

# Rappels SOLID

Les objectifs des principes SOLID sont de se définir un cadre permettant d'assurer une pérennité, une maintenabilité avec un côté industriel au développement logiciel.

## S-ingle Responsibility Principle

Chaque module, chaque classe ou chaque structure ne doit avoir qu'une seule et unique responsabilité.

## O-pen Closed Principle

Tout code ou classe ne devrait jamais être modifié(e) pour une évolution (sauf bug), mais devrait être suffisamment ouvert(e) aux évolutions futures. 

## L-iskov Substitution Principle

Toute nouvelle classe dérivée ne doit pas changer le comportement induit par sa classe de base et peut donc se substituer à sa classe de base.

## I-nterface Segregation Principle

Une classe implémentant une interface doit avoir l'utilité de toutes les éléments définis dans cette même interface.

## D-ependency Inversion Principle

Il s'agit d'assurer un couplage faible entre le contrat d'utilisation d'un objet agrégé avec l'implémentation de ce même objet agrégé afin de pouvoir l'injecter. 

# Object Calisthenics

9 règles définissent les Object Calisthenics :
1. Un seul niveau d'indentation par méthode
2. Ne jamais utiliser le mot-clé "else" ou ses dérivés
3. Encapsuler les types primitifs dans des objets
4. First Class Collection
5. Un seul point par ligne (sauf écriture fluide) ou Loi de Demeter
6. Ne pas utiliser d'abréviation
7. Garder les modules ou les entités petites
8. Pas plus de 2 variables d'instances (attributs ou propriétés)
9. Aucun Getter/Setter ou pas de propriété (sauf DTO, VO, Entity) principe de "Tell don't ask"
   
## Un seul niveau d'indentation par méthode

Ce principe améliore la lisibilité et permet d'avoir un code découpé et maintenable.

## Ne jamais utiliser le mot-clé "else" ou ses dérivés

Ce principe permet d'éviter les alternatives compliquées, tout en maintenant la lisibilité avec une code nominal explicite à la fin.
Quelques solutions pour ne plus avoir de "else" :
- Early Exit (cas métier ou respect des préconditions métier)
- Fail fast (exceptions liées aux prérequis selon respect des préconditions)
- Initialisation en amont

## Encapsuler les types primitifs dans des objets

Il est toujours préférable d'utiliser un type personnalisé plutôt qu'une primitive trop ouverte.

## First Class Collection

Il est préférable d'utiliser une classe hôte pour héberger une collection plutôt que de la mélanger au milieu d'autres considérations métier d'un même objet.

## Un seul point par ligne (sauf écriture fluide) ou Loi de Demeter

Il s'agit ici d'un lien avec la Loi de Demeter consistant à ne pas manipuler le contenu des objets ou désencapsuler depuis l'extérieur.
L'image souvent donnée lorsqu'on utilise plusieurs points par ligne : "Imaginons que pour payer le pain, on donne notre veste à la Boulangère en indiquant la marche à suivre pour trouver la monnaie : ouvrir la veste, chercher la poche de droite, récupérer le portefeuille, l'ouvrir et prendre la pièce d'un euro pour payer", au lieu de "Payer la boulangère".

## Ne pas utiliser d'abréviation

Il ne faut pas utiliser d'abréviation pour la lisibilité. Cependant, si on constate que les noms non abrégés de nos méthodes ou classes sont excessivement longs c'est sûrement parce qu'on ne respecte pas le principe SRP de SOLID...

## Garder les modules ou les entités petites

Les règles à respecter :
- Maximum 10 méthodes par classe
- Maximum 50 lignes par classe
- Maximum 10 classes par namespace

## Pas plus de 2 variables d'instances (attributs ou propriétés)

Il ne faut pas avoir plus de 2 variables d'instances pour une même classe ; cas signifiant que l'on a sûrement mal découpé et qu'on n'a pas respecté le principe SRP de SOLID...

## Aucun Getter/Setter ou pas de propriété (sauf DTO, VO, Entity) principe de "Tell don't ask"

Ce point est très proche de la Loi de Demeter avec un seul point par ligne. Il ne peut être pas toujours possible d'interdire les Getter mais il faut toujours limiter voir interdire les Setter afin d'utiliser des méthodes dédiées pour ne pas désencapsuler l'objet.

# Composition over Inheritance (sauf entité anémiée)

Il s’agit ici d’éviter l’héritage au profit de la composition sans perdre le polymorphisme.

Ce point doit être pondéré aux comportements d’un objet et non à la définition des caractéristiques d’un objet : comportements VS caractéristiques.

En effet, le côté systématique de ce pattern est plus difficilement applicable à des caractéristiques ou du stockage de données via des entités dites anémiées (uniquement getter/setter) comme les DTOs, ViewObjects, Data Entities…

Les éléments principaux et constitutifs de ce pattern :
- Usage d’interfaces pour décrire le comportement à composer.
- Autant de types d’implémentations que de comportements différents.
- Usage d’IoC/DI (voir D de SOLID) pour injecter ces comportements.
- Respect des principes de DRY (Don’t Repeat Yourself) assuré par l’injection de la même implémentation.

Pourquoi utiliser ce pattern et pourquoi considérer que l’héritage tend à devenir un anti-pattern ? Voici mon retour d'expérience…

En conception initiale d’un système de comportements hérité :
- On va essayer de recouvrir tous les cas d’évolution possibles pour respecter le O de SOLID.
- On va faire de l'over-engineering
- On ne va pas respecter les principes YAGNI (« You aren't gonna need it » ou on fait ce qu’on nous demande et pas plus). 
- On ne va pas respecter les principes KISS (« Keep It Simple Stupid! »). 

En évolution de code, à moyen terme voire court terme, on va être obliger de casser le C de SOLID… 
En effet, humainement, il aura été impossible de tout anticiper, il faudra casser ou adapter les classes de base à un moment donné.

