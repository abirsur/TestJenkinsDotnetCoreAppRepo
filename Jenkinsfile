pipeline {
  agent any
  stages {
    stage('Clean') {
      steps {
        bat 'dotnet clean'
        bat 'dotnet restore'
      }
    }

    stage('Build') {
      steps {
        bat 'dotnet build'
      }
    }

  }
}