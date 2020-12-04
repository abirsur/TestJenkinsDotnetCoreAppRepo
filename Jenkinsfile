pipeline {
  agent any
  stages {
    stage('Clean & Restore') {
      steps {
        echo 'Start Cleaning Job'
        bat 'dotnet clean'
        echo 'Start Restore Job'
        bat 'dotnet restore'
      }
    }

    stage('Build') {
      steps {
        echo 'Start Build Job'
        bat 'dotnet build'
      }
    }

  }
}