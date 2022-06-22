# Astral Fighter Development Guide
**Last Updated *(yyyy/mm/dd)*:**   *2022/06/21* **by** Connor

## Setting up the Repository locally

 1. by using the `cd` command in your terminal, navigate to the directory where you would like the repository to live on your computer 
	> Example: `cd Documents` will change the directory to the documents folder 
	
 2. clone the repository by using `git clone` 
	 > `git clone https://github.com/Connor-Schulz/Astral-Fighter.git`
	 
 3. using `cd` again, navigate to the new repository
	 > `cd Astral-Fighter` 
	 
You are now in the repository. 

**NOTE:** *This is the location you want your terminal to be in whenever you are making changes to the project. remember to `cd` back to this path every time you reopen a terminal window* 

## Opening the project in Unity Hub
- Within the `Projects` Tab within the Unity Hub application, select `Open`
- Navigate to the `Astral-Fighter` Repository location and open the file.
- Select, **but do not open**, the `Astral Fighter` folder that is inside the `Astral-Fighter` repository

Press `Open` in the file explorer and wait while Unity imports the project.

> **Note:** Going forward the project should now appear in the Unity Hub project tab and wont have to be imported again


## Making changes to the Repository 
**IMPORTANT:** *Before making any changes to the repository/project, ensure that you are not working on the `main` or `master` branch*

Creating and switching to a new branch:
> git branch **branchName123**
>  git checkout **branchName123**

or
> git checkout -b **branchName123**

Where `branchName123` is replaced by any branch name you want! (*as long as it's not `main` or `master` of course*)

---
Now that you are in your own branch, make any changes to the project that you like.
Once you are happy with the changes you can view all the changed files by running:
> git status

You can add all the files individually by listing them individually (with file extensions and paths) with single spaces to separate them like so:
> git add myFile.txt Assets/fighter.png Assets/Tiles/block.jpeg script123.cs

or, you could use `.` to indicate to git that you want to add all changes:
> git add .

---
Now that the changes are added to stage, you can commit the changes by doing:
> git commit -m "any message can go between the double-quotes. concisely explain what you changed here"

To push your changes to the Github Repository, Run:
> git push

**Note**: if your terminal throws this error at you after trying `git push`, run again using the provided command.
```
fatal: The current branch branchName123 has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin branchName123
```
Once that completes, your branch along with your changes should be available in the repositories [Branch Tab](https://github.com/Connor-Schulz/Astral-Fighter/branches)

## Merging your changes to Main

- In the repositories [Branch Tab](https://github.com/Connor-Schulz/Astral-Fighter/branches), find the branch that you want to merge and press the green button called `Compare & pull request`. 
- Follow the setup process for creating a pull request *(Just leave everything as is and hit `Create Pull Request`)*
- Once in the PR, find the `Merge Pull Request` button and select it. 

If successful, the green highlighting in the webpage will turn purple and say `Merged`

## Syncing your Local Branch with the Main Branch
When working with multiple developers, your branches will fall behind as others are updating `main` themselves. To ensure you're working with the most recent version of the project, run these commands in order:

> git checkout main
> git pull
> git checkout **branchName123**
> git merge main
> git push

where `branchName123` is the name of your branch
