pipeline {
  agent any
  stages {
    stage('Clean & Restore') {
      steps {
        echo 'Start Cleaning Job'
        sh 'dotnet clean'
        echo 'Start Restore Job'
        sh 'dotnet restore'
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